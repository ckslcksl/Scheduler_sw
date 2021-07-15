using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Model
{
    public class VersionModel : BindableBase
    {
        public string Version
        {
            get { return GetValue<string>(nameof(Version)); }
            set { SetValue(value, nameof(Version)); }
        }

        public string VersionDescr
        {
            get { return GetValue<string>(nameof(VersionDescr)); }
            set { SetValue(value, nameof(VersionDescr)); }
        }

        public string PlanStartDate
        {
            get { return GetValue<string>(nameof(PlanStartDate)); }
            set { SetValue(value, nameof(PlanStartDate)); }
        }

        public string PlanType
        {
            get { return GetValue<string>(nameof(PlanType)); }
            set { SetValue(value, nameof(PlanType)); }
        }

        public string Status
        {
            get { return GetValue<string>(nameof(Status)); }
            set { SetValue(value, nameof(Status)); }
        }
    }
}
