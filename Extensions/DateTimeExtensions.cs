using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Extensions
{
    public static class DateTimeExtensions
    {
        //sử dụng this để khi gọi phương thức trong lớp appuser thì có thể .CalculateAge() từ bên trong appuser
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            //ngày sinh lớn hơn ngày hôm nay thì chưa có sinh nhật thì phải trừ đi 1 tuổi
            if (dob.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
