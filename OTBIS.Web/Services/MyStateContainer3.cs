using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using OTBIS.Web.Models;

namespace OTBIS.Web.Services
{
    public class MyStateContainer3

    {
        public MyStateContainer3() { }   
        public ModelList Value { get; set; }

        public event Action OnStateChange;

        public void SetValue(ModelList value)
        {
            this.Value = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnStateChange?.Invoke();

    }
   
}
