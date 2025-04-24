﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progetta.Entities
{
    public class TaskTag
    {
        [ForeignKey(nameof(Task))]
        public int TaskId { get; set; }
        public TaskToDo Task { get; set; }

        [ForeignKey(nameof(Tag))]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
