using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Onderhoudsverzoek.UI;
using vera;
using VeraClient.Agents;
using VeraClient.Helpers;
using VeraClient.Logger;
using VeraClient.Soap;

namespace Onderhoudsverzoek
{
    public partial class frmKeuzeboom : Form
    {
        private SoapClient _client;
        private KeuzeboomAgent _agent;
        private OnderhoudsverzoekAgent _onderhoudsverzoekAgent;

        private string _keuzeBoomStapCode;
        private bool _logExpanded = false;
        private int _minFormHeight;

        public frmKeuzeboom()
        {
            InitializeComponent();

            LoggerSingleton.Instance.LogLevel = LogType.Debug;
            LoggerSingleton.Instance.OnLogEventCreated += (type, message) => textBox1.AppendText(type.ToString() + " - " + message + "\r\n");

            _minFormHeight = this.Size.Height;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                _client = new SoapClient(txtUrl.Text, txtDomain.Text, txtUserName.Text, txtPassword.Text);
                _agent = new KeuzeboomAgent(_client, new ApiInvoker(new SoapMessageBuilder(), new SoapMessageParser()));
                _onderhoudsverzoekAgent = new OnderhoudsverzoekAgent(_client, new ApiInvoker(new SoapMessageBuilder(), new SoapMessageParser()));

                ResetScreen();

                var ruimteSoortenAntwoord = _agent.GetRuimteSoorten(txtEenheid.Text);
                foreach (var antwoord in ruimteSoortenAntwoord.@object)
                {
                    cmbRuimteSoorten.Items.Add(new ComboboxItem<DGORMSbasis>(antwoord?.naam?.Value, antwoord));
                }
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void ResetScreen()
        {
            cmbRuimteSoorten.Items.Clear();
            cmbBouwElementen.Items.Clear();
            cmbGebrek.Items.Clear();
            cmbOnderdeel.Items.Clear();
            cmbOorzaken.Items.Clear();
        }

        private void cmbRuimteSoorten_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var selectedRuimteSoort = ((ComboboxItem<DGORMSbasis>)cmbRuimteSoorten.SelectedItem).Value;

                var bouwElementen = _agent.GetBouwElementen(txtEenheid.Text, selectedRuimteSoort.code.Value);
                cmbBouwElementen.SelectedIndex = -1;
                cmbBouwElementen.Items.Clear();
                foreach (var antwoord in bouwElementen.@object)
                {
                    cmbBouwElementen.Items.Add(new ComboboxItem<DGOBWEbasis>(antwoord?.naam?.Value, antwoord));
                }
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void cmbBouwElementen_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var selectedBouwElement = ((ComboboxItem<DGOBWEbasis>)cmbBouwElementen.SelectedItem).Value;
                var selectedRuimteSoort = ((ComboboxItem<DGORMSbasis>)cmbRuimteSoorten.SelectedItem).Value;

                var onderdelen = _agent.GetOnderdelen(txtEenheid.Text, selectedRuimteSoort.code.Value, selectedBouwElement.code.Value);
                cmbOnderdeel.SelectedIndex = -1;
                cmbOnderdeel.Items.Clear();
                foreach (var antwoord in onderdelen.@object)
                {
                    cmbOnderdeel.Items.Add(new ComboboxItem<DGOODLbasis>(antwoord?.naam?.Value, antwoord));
                }
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void cmbOnderdeel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var selectedRuimteSoort = ((ComboboxItem<DGORMSbasis>)cmbRuimteSoorten.SelectedItem).Value;
                var selectedBouwElement = ((ComboboxItem<DGOBWEbasis>)cmbBouwElementen.SelectedItem).Value;
                var selectedOnderdeel = ((ComboboxItem<DGOODLbasis>)cmbOnderdeel.SelectedItem).Value;

                var gebreken = _agent.GetGebreken(txtEenheid.Text, selectedRuimteSoort.code.Value, selectedBouwElement.code.Value, selectedOnderdeel.code.Value);
                cmbGebrek.SelectedIndex = -1;
                cmbGebrek.Items.Clear();
                foreach (var antwoord in gebreken.@object)
                {
                    cmbGebrek.Items.Add(new ComboboxItem<DGOGBRbasis>(antwoord?.naam?.Value, antwoord));
                }
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void cmbGebrek_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var selectedRuimteSoort = ((ComboboxItem<DGORMSbasis>)cmbRuimteSoorten.SelectedItem).Value;
                var selectedBouwElement = ((ComboboxItem<DGOBWEbasis>)cmbBouwElementen.SelectedItem).Value;
                var selectedOnderdeel = ((ComboboxItem<DGOODLbasis>)cmbOnderdeel.SelectedItem).Value;
                var selectedGebrek = ((ComboboxItem<DGOGBRbasis>)cmbGebrek.SelectedItem).Value;

                var specificaties = _agent.GetSpecificatie(txtEenheid.Text, selectedRuimteSoort.code.Value, selectedBouwElement.code.Value, selectedOnderdeel.code.Value, selectedGebrek.code.Value);
                this._keuzeBoomStapCode = specificaties.@object[0]?.keuzeboomStap?.identificatie?.Value;

                var oorzaken = _agent.GetOorzaken();
                cmbOorzaken.SelectedIndex = -1;
                cmbOorzaken.Items.Clear();
                foreach (var antwoord in oorzaken.@object)
                {
                    cmbOorzaken.Items.Add(new ComboboxItem<DGOORZbasis>(antwoord?.naam?.Value, antwoord));
                }
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btnToggleLog_Click(object sender, EventArgs e)
        {
            this.Size = _logExpanded ? new Size(this.Size.Width, this._minFormHeight) : new Size(this.Size.Width, this.Size.Height + 300);
            _logExpanded = !_logExpanded;
            btnToggleLog.Text = _logExpanded ? "^" : "v";
        }

        private void cmbOorzaken_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOorzaak = ((ComboboxItem<DGOORZbasis>)cmbOorzaken.SelectedItem).Value;
            var wordDoorbelast = _onderhoudsverzoekAgent.WordtKlantDoorbelast(txtHuurderNummer.Text, txtEenheid.Text, this._keuzeBoomStapCode, selectedOorzaak.code.Value);

            if (wordDoorbelast.@object.wordenKostenDoorbelast.Value)
            {
                var bedrag = wordDoorbelast.@object.doorTeBelastenBedrag.Value;
                if (bedrag == 0) bedrag = 50;

                if (MessageBox.Show($"Gaat u akkoord met de kosten: {bedrag:C}?", "Aanmaken onderhoudsverzoek", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                {
                    return;
                }
            }
            
            var result = _onderhoudsverzoekAgent.CreateOnderhoudsVerzoek(txtHuurderNummer.Text, "C00003090", txtEenheid.Text, this._keuzeBoomStapCode, selectedOorzaak.code.Value);
            if (result.melding.Length > 0)
            {
                MessageBox.Show($"Het onderhoudsverzoek ({result.melding[0]}) is aangemaakt.", "Aanmaken onderhoudsverzoek");
            }
            ResetScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://erp-vera-r17-test.meerstedewonen.nl/deerpweb/WebClient");
        }
    }
}