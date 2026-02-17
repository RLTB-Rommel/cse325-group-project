using System.ComponentModel.DataAnnotations;

namespace GradeProgressMonitoring.Models
{
    public class ComponentItem
    {
        public int ComponentItemId { get; set; }

        public int GradingComponentId { get; set; }
        public GradingComponent? GradingComponent { get; set; }

        [Required, MaxLength(150)]
        public string Label { get; set; } = "";

        public int OrderNo { get; set; } = 1;

        public decimal MaxScore { get; set; } = 100m;

        // For progressive encoding (admin/checker controls; scorer limited)
        public bool IsOpenForEncoding { get; set; } = true;
    }
}