using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Project_Management.Models
{
    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }


    [Table("Tasks")]
    public class TaskModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [AllowNull]
        public string Description { get; set; }

        [Required(ErrorMessage = "Due date is required")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        public PriorityLevel Priority { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "AssignedTo is required")]
        public string AssignedTo { get; set; }
    }
}
