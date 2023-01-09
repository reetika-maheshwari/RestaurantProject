using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantProject
{
    public partial class ReportFilterForm : Form
    {
        ReportType m_rpt_type = ReportType.None;
        ReportFilter m_Filter = null;
        internal ReportFilterForm(ReportType rpt_type, ReportFilter Filter)
        {
            InitializeComponent();
            m_rpt_type = rpt_type;
            m_Filter = Filter;

            DisplayFilter();
            this.Text = rpt_type.ToString();

        }

        private void DisplayFilter()
        {
            dtFrom.Value = m_Filter.from_date;
            dtTo.Value = m_Filter.to_date;
            txtNameLike.Text = m_Filter.name_like;
        }

        private void ReportFilterForm_Load(object sender, EventArgs e)
        {
            lblFrom.Visible = false;
            dtFrom.Visible = false;

            lblTo.Visible = false;
            dtTo.Visible = false;

            lblNameLike.Visible = false;
            txtNameLike.Visible = false;

            switch (m_rpt_type)
            {
                case ReportType.ItemReport:
                    lblNameLike.Visible = true;
                    txtNameLike.Visible = true;
                    break;

                case ReportType.SalesReport:
                    lblFrom.Visible = true;
                    dtFrom.Visible = true;

                    lblTo.Visible = true;
                    dtTo.Visible = true;

                    lblNameLike.Visible = true;
                    txtNameLike.Visible = true;
                    break;

                case ReportType.StaffReport:
                    lblNameLike.Visible = true;
                    txtNameLike.Visible = true;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            m_Filter.from_date = dtFrom.Value;
            m_Filter.to_date = dtTo.Value;
            m_Filter.name_like = txtNameLike.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
