using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Inspite of ArrayList, Generic are dynamic collection. No. of cells is not static */
/*Creating Enumerable Collection*/
namespace Mod06Demo02//Create class, inherite it to generic IList , right click and select implement implicity to get IList properties 
{
    class CustomerList : IList<Customer>// <> shows generic collection
    {
        private List<Customer> _internal = new List<Customer>();// _internal is created and we define it in sme method and properties shows here
        public Customer this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Customer item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Customer item)
        {
            return _internal.IndexOf(item);
        }

        public void Insert(int index, Customer item)
        {
            _internal.Insert(index,item);
        }

        public bool Remove(Customer item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _internal.GetEnumerator();
        }
        public IEnumerable<Customer> sorted
        {
            get
            {
                foreach (var customer in _internal.OrderBy(c => c.Name))
                {
                    yield return customer;
                }
            }
        }
    }
}
