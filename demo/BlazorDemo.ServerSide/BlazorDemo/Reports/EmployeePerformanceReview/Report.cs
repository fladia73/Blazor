using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.EmployeePerformanceReview {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.EmployeePerformanceReviewName;
            DisplayName = ReportNames.EmployeePerformanceReview;
        }
    }
}
