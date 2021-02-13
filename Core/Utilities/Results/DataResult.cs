using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result,IDataResult<T> //bu class resulttan inherit ediyor.
    {
        public DataResult(T data, bool success, string message):base(success,message)  //base e success ve mesajı gönder. resulttaki success ve message tekrar yazmamak için
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }

        public T Data { get; } //IDataResult<T> için ekledik. 
    }
}
