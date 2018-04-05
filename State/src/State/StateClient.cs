using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace State
{
    //client class, context
    public class StateClient : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private BaseState _state;
        public BaseState State
        {
            get { return _state; }
            set { SetField(ref _state, value); }
        }

        protected bool SetField<T>(ref T field, T value,  [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public StateClient()
        {
            this.PropertyChanged += (sender, arg)=>{
                System.Console.WriteLine($"sender={sender};arg={arg.PropertyName}");
            };
        }

        public void Process()
        {
            _state.Increment();
        }
    }
}
