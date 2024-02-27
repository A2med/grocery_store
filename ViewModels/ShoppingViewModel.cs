using Gerocery.data;
using Microsoft.Maui;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gerocery.ViewModels
{
    [QueryProperty("lst", "Items")]
    public class ShoppingViewModel : BaseViewModel
    {
        Category2 _lst;

        decimal _prdertotal;
        public decimal prdertotal { get => _prdertotal; set { _prdertotal = value; onpropertyChange(); } }
        public Category2 lst { get => _lst; set { _lst = value; onpropertyChange(); } }
        public ICommand increment { set; get; }
        public ICommand decrement { set; get; }

        ObservableCollection<Category2> _LstItem;
        public ObservableCollection<Category2> lstItem { get => _LstItem; set { _LstItem = value; onpropertyChange(); } }

        public ShoppingViewModel()
        {
            lst = new Category2();
            lstItem = consData.LstItems;
            prdertotal = lstItem.Sum(a => a.Qty * a.salary);



            //  LstItem = maindata.lstitems;

            increment = new Command<Category2>(onbtn);
            decrement = new Command<Category2>(ondecrement);



        }
        public async void onbtn(Category2 model)
        {
            // consData.LstItems.Add(model);


            var item = lstItem.FirstOrDefault(a => a.id == model.id);
            if (item != null)
            {
                foreach (var item2 in lstItem)
                    if (item2.id == model.id)
                        item2.Qty++;
            }
            else
            {
                lstItem.Add(new Category2()
                {
                    ItemName = model.ItemName,
                    salary = model.salary,
                    Qty = 1

                }


                    );
            }
            prdertotal = lstItem.Sum(a => a.Qty * a.salary);



        }
        public async void ondecrement(Category2 model)
        {
            var item = lstItem.FirstOrDefault(a => a.id == model.id);


            if (item != null)
            {
                //foreach (var item2 in lstItem)
                //{

                if (item.Qty > 0)

                    item.Qty--;
                else if(item.Qty==0)
                {
                    lstItem.Remove(item);
                }
            }









            prdertotal = lstItem.Sum(a => a.Qty * a.salary);

        }


    }
    }



