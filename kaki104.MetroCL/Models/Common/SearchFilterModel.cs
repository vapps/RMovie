using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaki104.MetroCL.Models.Common
{
    public sealed class SearchFilterModel : kaki104.MetroCL.Common.BindableBase
    {
        private String _query;
        private int _count;
        private bool _active;

        public SearchFilterModel(String query, int count, bool active = false)
        {
            this.Query = query;
            this.Count = count;
            this.Active = active;
        }

        public override String ToString()
        {
            return Description;
        }

        public String Query
        {
            get { return _query; }
            set { if (this.SetProperty(ref _query, value)) this.OnPropertyChanged("Description"); }
        }

        public int Count
        {
            get { return _count; }
            set { if (this.SetProperty(ref _count, value)) this.OnPropertyChanged("Description"); }
        }

        public bool Active
        {
            get { return _active; }
            set { this.SetProperty(ref _active, value); }
        }

        public String Description
        {
            get { return String.Format("{0} ({1})", _query, _count); }
        }

    }
}
