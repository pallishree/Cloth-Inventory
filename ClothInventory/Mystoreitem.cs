using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothInventory
{
    enum Color { Black, Blue, Red };
    enum DeptType { Men, Women, Boy, Girl };
    enum Size { XS,S,M,L,XL};

    public class MyStoreItem
    {
        #region variables
        /// <summary>
        /// regular price of the item
        /// </summary>
        float regPrice;

        /// <summary>
        /// Discounted price of the item
        /// </summary>        
        float disPrice;

        /// <summary>
        /// this is the product web
        /// </summary>
        int id;

        /// <summary>
        /// Review of the item
        /// </summary>
        float review;

        /// <summary>
        /// How many review
        /// </summary>
        int reviewcount;
        /// <summary>
        /// Color of the item
        /// </summary>
        Color itemColor;
        /// <summary>
        /// what is the dept type 
        /// </summary>
        DeptType depttype;

        /// <summary>
        /// what is the size of the item
        /// </summary>
        Size size;
        #endregion

        #region properties

        #endregion

        public MyStoreItem(int productid, DeptType type)
        {

        }
        public void MyStoreItem(int productid, float price)
        {

        }
    }
}
