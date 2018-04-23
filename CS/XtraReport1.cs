using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace RepStyleSheets {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();

            CreateCustomStyles();
        }

        public void CreateCustomStyles() {
            XRControlStyle style1 = new XRControlStyle();
            XRControlStyle style2 = new XRControlStyle();

            style1.Name = "style1";
            style1.BackColor = Color.AliceBlue;
            style2.Name = "style2";
            style2.BackColor = Color.Chocolate;

            StyleSheet.Add(style1);
            StyleSheet.Add(style2);
        }

        internal void ApplayStyles() {
            try {
                xrLabel2.Styles.EvenStyle = StyleSheet[0];
                xrLabel2.Styles.OddStyle = StyleSheet[1];
                CreateDocument();
            }
            catch(Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void ResetStyles() {
            xrLabel2.Styles.EvenStyle = null;
            xrLabel2.Styles.OddStyle = null;
            StyleSheet.Clear();
            CreateDocument();
        }

    }
}
