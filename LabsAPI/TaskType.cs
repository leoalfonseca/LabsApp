using System.ComponentModel.DataAnnotations;

namespace LabsAPI
{
    public class TaskType
    {

        public int Id { get; set; }
        [StringLength(20)]
        public string TaskName { get; set; } = string.Empty;

    }
}
