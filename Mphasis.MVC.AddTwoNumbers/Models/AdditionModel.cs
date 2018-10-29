using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Mphasis.MVC.AddTwoNumbers.Models
{
    public class AdditionModel : IAddition
    {
        #region  Properties
        
        [Required(ErrorMessage = "Please enter number 1")]
        [RegularExpression("^[0-9]*$")]
        public double Number1 { get; set; }
        
        [Required(ErrorMessage = "Please enter Number 2")]
        [RegularExpression("^[0-9]*$")]
        public double Number2 { get; set; }
        public double Result { get; set; }

        #endregion


        #region Methods

        /// <summary>
        /// Method to add two numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public double Add(AdditionModel model)
        {
            return model.Number1 + model.Number2;
        }

        #endregion
    }
}