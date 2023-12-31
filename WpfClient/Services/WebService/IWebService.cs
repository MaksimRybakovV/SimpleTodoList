﻿using Entities.Dtos.TodoTaskDtos;
using Entities.Dtos.UserDtos;
using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfClient.Services.WebService
{
    internal interface IWebService
    {
        public Task<ServiceResponse<int>> Registration(AddUserDto newUser);
        public Task<ServiceResponse<GetUserDto>> Authorization(string username, string passwordHash);
        public Task<ServiceResponse<GetUserDto>> RefreshToken(TokenUserDto user, string token);
        public Task<ServiceResponse<GetUserDto>> Logout(int id, string token);
        public Task<PageServiceResponse<List<GetTodoTaskDto>>> GetTasksPageByUser(int id, int page, int pageSize, string token);
        public Task<ServiceResponse<string>> DeleteTask(int id, string token);
        public Task<ServiceResponse<string>> UpdateTask(UpdateTodoTaskDto updatedTask, string token);
        public Task<ServiceResponse<int>> AddTask(AddTodoTaskDto newTask, int id, string token);
    }
}
