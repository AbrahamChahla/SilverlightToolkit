// (c) Copyright Microsoft Corporation.
// This source is subject to [###LICENSE_NAME###].
// Please see [###LICENSE_LINK###] for details.
// All other rights reserved.
//
// <autogenerated />
// The Visual Studio metadata is not subjected to same source analysis

namespace Microsoft.VisualStudio.TestTools.Resources
{

    using System;
    using System.Resources;
    using System.Diagnostics;
    using System.Globalization;
    using System.Collections.Generic;

#if DESKTOP
    [Serializable]    
#endif
    internal partial class EqtMessage
    {
        private Object[] m_array;
        private string m_name;
#if DESKTOP
        [NonSerialized]
#endif
        private ResourceManager m_rm;
        private Type m_t;
        static Dictionary<Type, ResourceManager> m_resourceManagers = new Dictionary<Type, ResourceManager>();

        // Private constructor for serialization support
        private EqtMessage()
        {
        }

        public EqtMessage(string name, Type type, ResourceManager resourceManager, Object[] array)
        {
            m_name = name;
            m_rm = resourceManager;
            m_array = array;
            m_t = type;
        }

        // Comment this attribute back in when it's time to review our usage of messages
        // [Obsolete("Check and make sure you mean to use an EqtMessage as a string. If so, use ToString().")]
        public static implicit operator string(EqtMessage eqtMessage)
        {
            return eqtMessage.ToString();
        }

        public ResourceManager RM
        {
            get
            {
                if (m_rm == null)
                {
                    if (!m_resourceManagers.TryGetValue(m_t, out m_rm))
                    {
                        m_resourceManagers.Add(m_t, m_rm = new ResourceManager(m_t));
                    }
                }
                return m_rm;
            }
        }

        internal string Name
        {
            get
            {
                return m_name;
            }
        }

        internal Object[] Params
        {
            get
            {
                return m_array;
            }
        }

        public override string ToString()
        {
            string format = RM.GetString(Name, CultureInfo.CurrentUICulture);
            Object[] array = Params;
            if (array != null)
            {
                return string.Format(CultureInfo.CurrentCulture, format, array);
            }
            return format;
        }
    }

}