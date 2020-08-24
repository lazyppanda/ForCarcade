using ForCarcade.Helpers;
using ForCarcade.Infrastructure;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForCarcade
{
    public partial class _Default : Page
    {
        private PaymentsViewModel PaymentsView { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        protected void ChangePage(Object sender, GridViewPageEventArgs e)
        {
            MyGrid.PageIndex = e.NewPageIndex;
            MyGrid.DataBind();
        }

        protected void FilterButton_Click(object sender, EventArgs e)
        {
            string searchName = SearchCompanyNameInput.Text;

            var dateHelper = new InputWebFormsDateHelper();
            DateTime searchDate = dateHelper.ConvertDateStringToDateTime(SearchPaymentDateInput.Text);

            PaymentsView = new PaymentsViewModel(searchPartOfName: searchName, searchDate: searchDate);

            MyGrid.DataSource = PaymentsView.Payments;
            MyGrid.SetPageIndex(0);
            
            MyGrid.DataBind();
        }

        private void InitGrid()
        {
            PaymentsView = new PaymentsViewModel();
            
            MyGrid.DataSource = PaymentsView.Payments;
            MyGrid.PageSize = PaymentsView.PageSize;

            MyGrid.AutoGenerateColumns = false;
            MyGrid.AllowPaging = true;
            
            MyGrid.DataBind();
        }


    }
}