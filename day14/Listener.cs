using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace day14
{
    class Listener<TKey>
    {
        List<ListenerEntry<TKey>> listOfChange = new List<ListenerEntry<TKey>>();
        public void MagazineAdded(object obj, MagazineListHandlerEventArgs<TKey> a)
        {
            this.listOfChange.Add(new ListenerEntry<TKey>(a.NameCollection, a.Info, a.Number));
        }
        public void MagazineReplaced(object obj, MagazineListHandlerEventArgs<TKey> a)
        {
            this.listOfChange.Add(new ListenerEntry<TKey>(a.NameCollection, a.Info, a.Number));
        }
        public void PropertyChanged(object obj, PropertyChangedEventArgs e)
        {

            this.listOfChange.Add(new ListenerEntry<TKey>("list", e.PropertyName, 0));
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < listOfChange.Count; i++)
            {
                result += listOfChange[i].ToString() + "\n";
            }
            return result;
        }
    }
}
