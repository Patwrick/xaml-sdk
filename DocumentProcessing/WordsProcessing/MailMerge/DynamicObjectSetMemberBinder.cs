﻿using System.Dynamic;

namespace MailMerge
{
    public class DynamicObjectSetMemberBinder : SetMemberBinder
    {
        public DynamicObjectSetMemberBinder(string name, bool ignoreCase)
            : base(name, ignoreCase)
        {
        }

        public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
        {
            return target;
        }
    }
}
