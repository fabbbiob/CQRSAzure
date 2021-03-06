﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CQRSAzure.CQRSdsl.Dsl.CustomCode.Validation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ValidationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CQRSAzure.CQRSdsl.Dsl.CustomCode.Validation.ValidationMessages", typeof(ValidationMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data type of a parameter with IsAggregateKey set should match the data type of the aggregate key.
        /// </summary>
        internal static string AggregateKeyDataTypeMatch {
            get {
                return ResourceManager.GetString("AggregateKeyDataTypeMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an aggregate identifier cannot be blank.
        /// </summary>
        internal static string AggregateNameNotBlank {
            get {
                return ResourceManager.GetString("AggregateNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Each aggregate must have an unique name.
        /// </summary>
        internal static string AggregateNameUnique {
            get {
                return ResourceManager.GetString("AggregateNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the aggregate must be a valid programming name.
        /// </summary>
        internal static string AggregateNameValid {
            get {
                return ResourceManager.GetString("AggregateNameValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a classifier cannot be blank.
        /// </summary>
        internal static string ClassifierNameNotBlank {
            get {
                return ResourceManager.GetString("ClassifierNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the classifier must be unique for any given aggregate identifier.
        /// </summary>
        internal static string ClassifierNameUnique {
            get {
                return ResourceManager.GetString("ClassifierNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a command definition cannot be blank.
        /// </summary>
        internal static string CommandDefinitionNameNotBlank {
            get {
                return ResourceManager.GetString("CommandDefinitionNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a command must be unique for any given  aggregate identifier.
        /// </summary>
        internal static string CommandDefinitionNameUnique {
            get {
                return ResourceManager.GetString("CommandDefinitionNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a command definition must be a valid programming name.
        /// </summary>
        internal static string CommandDefinitionNameValid {
            get {
                return ResourceManager.GetString("CommandDefinitionNameValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a command should be a present tense verb.
        /// </summary>
        internal static string CommandDefinitionPresentTense {
            get {
                return ResourceManager.GetString("CommandDefinitionPresentTense", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a command parameter must not be blank.
        /// </summary>
        internal static string CommandParameterNameNotBlank {
            get {
                return ResourceManager.GetString("CommandParameterNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a command parameter must be unique within any given command.
        /// </summary>
        internal static string CommandParameterNameUnique {
            get {
                return ResourceManager.GetString("CommandParameterNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an event cannot be blank.
        /// </summary>
        internal static string EventNameNotBlank {
            get {
                return ResourceManager.GetString("EventNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an event should be a past tense verb.
        /// </summary>
        internal static string EventNamePastTense {
            get {
                return ResourceManager.GetString("EventNamePastTense", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an event should be unique for any given aggregate identifier.
        /// </summary>
        internal static string EventNameUnique {
            get {
                return ResourceManager.GetString("EventNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an event must be a valid programming name.
        /// </summary>
        internal static string EventNameValid {
            get {
                return ResourceManager.GetString("EventNameValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an identity group may not be blank.
        /// </summary>
        internal static string IdentityGroupNameNotBlank {
            get {
                return ResourceManager.GetString("IdentityGroupNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an identity group must be unique for any given aggregate identifier.
        /// </summary>
        internal static string IdentityGroupNameUnique {
            get {
                return ResourceManager.GetString("IdentityGroupNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of an identity group must not contain invalid characters.
        /// </summary>
        internal static string IdentityGroupNameValid {
            get {
                return ResourceManager.GetString("IdentityGroupNameValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The projection event property operation must specify a source event name.
        /// </summary>
        internal static string ProjectionEventPropertyOperantionEventBlank {
            get {
                return ResourceManager.GetString("ProjectionEventPropertyOperantionEventBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The projection event property operation have a source event name that is linked to the projection.
        /// </summary>
        internal static string ProjectionEventPropertyOperantionEventInvalid {
            get {
                return ResourceManager.GetString("ProjectionEventPropertyOperantionEventInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For this property operation, a source field from the event is required.
        /// </summary>
        internal static string ProjectionEventPropertyOperationSourceBlank {
            get {
                return ResourceManager.GetString("ProjectionEventPropertyOperationSourceBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source field for this property oepration must match the fields in the handled event.
        /// </summary>
        internal static string ProjectionEventPropertyOperationSourceInvalid {
            get {
                return ResourceManager.GetString("ProjectionEventPropertyOperationSourceInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The projection event property operation must specify a target field for the operation.
        /// </summary>
        internal static string ProjectionEventPropertyOperationTargetBlank {
            get {
                return ResourceManager.GetString("ProjectionEventPropertyOperationTargetBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target field for a projection event property operation must be a property of the projection.
        /// </summary>
        internal static string ProjectionEventPropertyOperationTargetInvalid {
            get {
                return ResourceManager.GetString("ProjectionEventPropertyOperationTargetInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a projection cannot be blank.
        /// </summary>
        internal static string ProjectionNameNotBlank {
            get {
                return ResourceManager.GetString("ProjectionNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a projection must be unique for any given aggregate identifier.
        /// </summary>
        internal static string ProjectionNameUnique {
            get {
                return ResourceManager.GetString("ProjectionNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a projection must be a valid programming name.
        /// </summary>
        internal static string ProjectionNameValid {
            get {
                return ResourceManager.GetString("ProjectionNameValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a projection property may not be blank.
        /// </summary>
        internal static string ProjectionPropertyNameNotBlank {
            get {
                return ResourceManager.GetString("ProjectionPropertyNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a projection property must be unique within that projection definition.
        /// </summary>
        internal static string ProjectionPropertyNameUnique {
            get {
                return ResourceManager.GetString("ProjectionPropertyNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a query definition cannot be blank.
        /// </summary>
        internal static string QueryDefinitionNameNotBlank {
            get {
                return ResourceManager.GetString("QueryDefinitionNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a query must be unique for any given aggregate identifier.
        /// </summary>
        internal static string QueryDefinitionNameUnique {
            get {
                return ResourceManager.GetString("QueryDefinitionNameUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a query definition must be a valid programming name.
        /// </summary>
        internal static string QueryDefinitionNameValid {
            get {
                return ResourceManager.GetString("QueryDefinitionNameValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a query parameter can not be blank.
        /// </summary>
        internal static string QueryParameterNameNotBlank {
            get {
                return ResourceManager.GetString("QueryParameterNameNotBlank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the query parameter must be unique within any given query.
        /// </summary>
        internal static string QueryParameterNameUnique {
            get {
                return ResourceManager.GetString("QueryParameterNameUnique", resourceCulture);
            }
        }
    }
}
