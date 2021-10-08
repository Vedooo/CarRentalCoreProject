using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.DataResultOptions.SuccessDataResultOption
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        private object carListed;

        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }

    }
}
