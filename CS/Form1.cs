using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UserDesigner;
using System.Reflection;
using System.ComponentModel.Design;
using DevExpress.XtraReports.UI;

namespace RepStyleSheets {
    public partial class Form1 : Form {
        XtraReport1 report;
        
        public Form1() {
            InitializeComponent();

            report = new XtraReport1();
        }

        private void Form1_Load(object sender, EventArgs e) {
            report.ApplayStyles();
        }

        private void button1_Click(object sender, EventArgs e) {
            XRDesignFormEx designerForm = new XRDesignFormEx();
            designerForm.OpenReport(report);
            designerForm.DesignPanel.ExecCommand(ReportCommand.ShowPreviewTab);
            designerForm.ShowDialog();
            designerForm.OpenReport((XtraReport)null);
            designerForm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                report.StyleSheet.SaveToFile(saveFileDialog1.FileName);
        }

        private void button3_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                report.StyleSheet.LoadFromFile(openFileDialog1.FileName);

            report.ApplayStyles();
        }

        private void button4_Click(object sender, EventArgs e) {
            report.ResetStyles();
        }

        private void button5_Click(object sender, EventArgs e) {
            XRDesignFormEx designerForm = new XRDesignFormEx();
            designerForm.OpenReport(report);

            StyleSheetEditorForm ssef = new StyleSheetEditorForm(report, null);

            ssef.ShowDialog();

            designerForm.OpenReport((XtraReport)null);
            designerForm.Dispose();
        }
    }
}