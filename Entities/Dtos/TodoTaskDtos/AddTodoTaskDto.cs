﻿using Entities.Enums;

namespace Entities.Dtos.TodoTaskDtos
{
    public class AddTodoTaskDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime Deadline { get; set; }
        public TaskCategory Category { get; set; }
        public TaskPriority Priority { get; set; }
    }
}
