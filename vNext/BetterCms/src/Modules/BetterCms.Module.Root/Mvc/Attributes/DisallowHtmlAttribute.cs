﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ModelBinding;
using Microsoft.AspNet.Mvc.ModelBinding.Validation;

namespace BetterCms.Module.Root.Mvc.Attributes
{
    /// <summary>
    /// Validates the field to not contain any HTML.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class DisallowHtmlAttribute : ValidationAttribute, IClientModelValidator
    {
        /// <summary>
        /// The client validation rule.
        /// </summary>
        private const string clientValidationRule = "disallowhtml";

        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        /// <param name="value">The value of the object to validate.</param>
        /// <returns>
        /// true if the specified value is valid; otherwise, false.
        /// </returns>
        public override bool IsValid(object value)
        {
            try
            {
                var possibleHtml = value as string;

                if (string.IsNullOrWhiteSpace(possibleHtml))
                {
                    return true;
                }
                var regex = new Regex(RootModuleConstants.HtmlRegularExpression);
                return !regex.IsMatch(possibleHtml);
            }
            catch (Exception exception)
            {
                throw new Exception("An error occured in DisallowHtml", exception);
            }
        }

        /// <summary>
        /// When implemented in a class, returns client validation rules for that class.
        /// </summary>
        /// <param name="context">The client model validation context.</param>
        /// <returns>
        /// The client validation rules for this validator.
        /// </returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ClientModelValidationContext context)
        {
            var rule = new ModelClientValidationRule (clientValidationRule, ErrorMessageString ?? "Field must not contain HTML.");
            rule.ValidationParameters.Add("pattern", RootModuleConstants.HtmlRegularExpression);

            yield return rule;
        }
    }
}