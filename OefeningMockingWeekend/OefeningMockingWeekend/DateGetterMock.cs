using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingWeekend
{
    public class DateGetterMock : IDateGetter
    {

        private DateTime _dayOfWeek;

        public DateGetterMock(DateTime dayOfWeek)
        {
            _dayOfWeek = dayOfWeek;
        }

        public DateTime GetDate()
        {
            return _dayOfWeek;
        }
    }
}
