using DomainNotification.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DomainNotification.Domain.ValueObjects
{
    public class ValueObject
    {
        public Error Notification { get; } = new Error();
        public virtual void Validate() { }
        protected void Fail(bool condition, ErrorDescription error)
        {
            if (condition)
                Notification.Add(error);
        }
        public bool IsValid()
        {
            return !Notification.HasErrors;
        }

        protected void IsInvalidEmail(string s, ErrorDescription error)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Fail(!Regex.IsMatch(s, pattern), error);
        }

        public static ErrorDescription InvalidEmail = new ErrorDescription("Invalid E-mail address", new Critical());
    }
}
