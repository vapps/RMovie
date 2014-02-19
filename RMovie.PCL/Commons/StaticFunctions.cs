using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RMovie.PCL.Commons
{
    public static class StaticFunctions
    {
        public static void InvokeIfRequiredAsync(SynchronizationContext context, SendOrPostCallback callback, object state)
        {
            context.Post(callback, state); //모든 프레임웍에서 동작할려면 이거 써야한다는데..
        }

        /// <summary>
        /// 모델 뷰모델 모두 사용 - 기본 컨텍스트
        /// </summary>
        public static System.Threading.SynchronizationContext BaseContext { get; set; }
    }
}
