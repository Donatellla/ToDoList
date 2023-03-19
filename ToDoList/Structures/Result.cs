using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Structures
{
    public class Result
    {
        private bool isSuccess;
        private string message;

        public Result()
        {

        }

        public Result(bool isSuccess, string message)
        {
            this.isSuccess = isSuccess;
            this.message = message;
        }

        public bool IsSuccess { get => isSuccess; set => isSuccess = value; }
        public string Message { get => message; set => message = value; }
    }
}
