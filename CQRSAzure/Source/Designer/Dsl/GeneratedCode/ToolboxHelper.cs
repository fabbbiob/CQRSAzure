﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace CQRSAzure.CQRSdsl.Dsl
{
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	/// <remarks>
	/// Double-derived class to allow easier code customization.
	/// </remarks>
	public partial class CQRSdslToolboxHelper : CQRSdslToolboxHelperBase 
	{
		/// <summary>
		/// Constructs a new CQRSdslToolboxHelper.
		/// </summary>
		public CQRSdslToolboxHelper(global::System.IServiceProvider serviceProvider)
			: base(serviceProvider) { }
	}
	
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Justification = "The store is disposed on domain shut down")]
	public abstract class CQRSdslToolboxHelperBase
	{
		/// <summary>
		/// Toolbox item filter string used to identify CQRSdsl toolbox items.  
		/// </summary>
		/// <remarks>
		/// See the MSDN documentation for the ToolboxItemFilterAttribute class for more information on toolbox
		/// item filters.
		/// </remarks>
		public const string ToolboxFilterString = "CQRSdsl.1.1";
		/// <summary>
		/// Toolbox item filter string used to identify ProjectionEventConnectionTool connector tool.
		/// </summary>
		public const string ProjectionEventConnectionToolFilterString = "ProjectionEventConnectionTool.1.1";
		/// <summary>
		/// Toolbox item filter string used to identify AggregateParenthoodConnectionTool connector tool.
		/// </summary>
		public const string AggregateParenthoodConnectionToolFilterString = "AggregateParenthoodConnectionTool.1.1";
		/// <summary>
		/// Toolbox item filter string used to identify ClassifierEventConnectionTool connector tool.
		/// </summary>
		public const string ClassifierEventConnectionToolFilterString = "ClassifierEventConnectionTool.1.1";

	
		private global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem> toolboxItemCache = new global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem>();
		private DslModeling::Store toolboxStore;
		
		private global::System.IServiceProvider sp;
		
		/// <summary>
		/// Constructs a new CQRSdslToolboxHelperBase.
		/// </summary>
		protected CQRSdslToolboxHelperBase(global::System.IServiceProvider serviceProvider)
		{
			if(serviceProvider == null) throw new global::System.ArgumentNullException("serviceProvider");
			
			this.sp = serviceProvider;
		}
		
		/// <summary>
		/// Serivce provider used to access services from the hosting environment.
		/// </summary>
		protected global::System.IServiceProvider ServiceProvider
		{
			get
			{
				return this.sp;
			}
		}

		/// <summary>
		/// Returns the display name of the tab that should be opened by default when the editor is opened.
		/// </summary>
		public static string DefaultToolboxTabName
		{
			get
			{
				return global::CQRSAzure.CQRSdsl.Dsl.CQRSdslDomainModel.SingletonResourceManager.GetString("CQRS DesignerToolboxTab", global::System.Globalization.CultureInfo.CurrentUICulture);
			}
		}
		
		
		/// <summary>
		/// Returns the toolbox items count in the default tool box tab.
		/// </summary>
		public static int DefaultToolboxTabToolboxItemsCount
		{
			get
			{
				return 10;
			}
		}
		

		/// <summary>
		/// Returns a list of custom toolbox items to be added dynamically
		/// </summary>
		public virtual global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem> toolboxItems = new global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem>();
			return toolboxItems;
		}
		
		/// <summary>
		/// Creates an ElementGroupPrototype for the element tool corresponding to the given domain class id.
		/// Default behavior is to create a prototype containing an instance of the domain class.
		/// Derived classes may override this to add additional information to the prototype.
		/// </summary>
		protected virtual DslModeling::ElementGroupPrototype CreateElementToolPrototype(DslModeling::Store store, global::System.Guid domainClassId)
		{
			DslModeling::ModelElement element = store.ElementFactory.CreateElement(domainClassId);
			DslModeling::ElementGroup elementGroup = new DslModeling::ElementGroup(store.DefaultPartition);
			elementGroup.AddGraph(element, true);
			return elementGroup.CreatePrototype();
		}

		/// <summary>
		/// Returns instance of ModelingToolboxItem based on specified name.
		/// This method must be called from within a Transaction. Failure to do so will result in an exception
		/// </summary>
		/// <param name="itemId">unique name of desired ToolboxItem</param>
		/// <param name="store">Store to perform the operation against</param>
		/// <returns>An instance of ModelingToolboxItem if the itemId can be resolved, null otherwise</returns>
		public virtual DslDesign::ModelingToolboxItem GetToolboxItem(string itemId, DslModeling::Store store)
		{
			DslDesign::ModelingToolboxItem result = null;
			if (string.IsNullOrEmpty(itemId))
			{
				return null;
			}
			if (store == null)
			{
				return null;
			}
			global::System.Resources.ResourceManager resourceManager = global::CQRSAzure.CQRSdsl.Dsl.CQRSdslDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;
			switch(itemId)
			{
				case "CQRSAzure.CQRSdsl.Dsl.AggregateToolToolboxItem":
					// Add AggregateTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.AggregateToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("AggregateToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("AggregateToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"Aggregate", // F1 help keyword for the toolbox item.
						resourceManager.GetString("AggregateToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::CQRSAzure.CQRSdsl.Dsl.AggregateIdentifier.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.EventDefinitionToolToolboxItem":
					// Add EventDefinitionTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.EventDefinitionToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						2, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("EventDefinitionToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("EventDefinitionToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"EventDefinitionTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("EventDefinitionToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::CQRSAzure.CQRSdsl.Dsl.EventDefinition.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.ProjectionToolToolboxItem":
					// Add ProjectionTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.ProjectionToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						3, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ProjectionToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ProjectionToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ProjectionTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ProjectionToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::CQRSAzure.CQRSdsl.Dsl.ProjectionDefinition.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.CommandToolToolboxItem":
					// Add CommandTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.CommandToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						4, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("CommandToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("CommandToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"CommandTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("CommandToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::CQRSAzure.CQRSdsl.Dsl.CommandDefinition.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.QueryToolToolboxItem":
					// Add QueryTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.QueryToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						5, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("QueryToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("QueryToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"QueryTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("QueryToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::CQRSAzure.CQRSdsl.Dsl.QueryDefinition.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.ProjectionEventConnectionToolToolboxItem":

					// Add ProjectionEventConnectionTool connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.ProjectionEventConnectionToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						6, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ProjectionEventConnectionToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ProjectionEventConnectionToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ProjectionEvent", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ProjectionEventConnectionToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ProjectionEventConnectionToolFilterString)
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.AggregateParenthoodConnectionToolToolboxItem":

					// Add AggregateParenthoodConnectionTool connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.AggregateParenthoodConnectionToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						7, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("AggregateParenthoodConnectionToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("AggregateParenthoodConnectionToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"AggregateParenthoodConnectionTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("AggregateParenthoodConnectionToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(AggregateParenthoodConnectionToolFilterString)
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.IdentityGroupToolToolboxItem":
					// Add IdentityGroupTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.IdentityGroupToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						8, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("IdentityGroupToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("IdentityGroupToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"IdentityGroup", // F1 help keyword for the toolbox item.
						resourceManager.GetString("IdentityGroupToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::CQRSAzure.CQRSdsl.Dsl.IdentityGroup.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.ClassifierToolToolboxItem":
					// Add ClassifierTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.ClassifierToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						9, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ClassifierToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ClassifierToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ClassifierTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ClassifierToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::CQRSAzure.CQRSdsl.Dsl.Classifier.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "CQRSAzure.CQRSdsl.Dsl.ClassifierEventConnectionToolToolboxItem":

					// Add ClassifierEventConnectionTool connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"CQRSAzure.CQRSdsl.Dsl.ClassifierEventConnectionToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						10, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ClassifierEventConnectionToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ClassifierEventConnectionToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"CQRSAzure.CQRSdsl.Dsl.CQRS DesignerToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("CQRS DesignerToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ClassifierEventConnection", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ClassifierEventConnectionToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ClassifierEventConnectionToolFilterString)
						});
					break;
				default:
					break;
			} // end switch
			
			return result;
		}
		

		/// <summary>
		/// The store toe be used for all the toolbox item creation
		/// </summary>
		protected DslModeling::Store ToolboxStore
		{
			get
			{ 
				if (toolboxStore==null)
				{
					toolboxStore = new DslModeling::Store(this.ServiceProvider);
					EventHandler StoreCleanUp = (o, e) =>
					{
						//Since Store implements IDisposable, we need to dispose it when we're finished
						if (this.toolboxStore != null)
						{
							this.toolboxStore.Dispose();
						}
						this.toolboxStore = null;
					};
					//There is no DomainUnload event for the default AppDomain, so we listen for both ProcessExit and DomainUnload
					AppDomain.CurrentDomain.ProcessExit += new EventHandler(StoreCleanUp);
					AppDomain.CurrentDomain.DomainUnload += new EventHandler(StoreCleanUp);
					
					//load the domain model
					toolboxStore.LoadDomainModels(typeof(global::CQRSAzure.CQRSdsl.Dsl.CQRSdslDomainModel));
					
				}
				return toolboxStore;
			}
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" returns the the toolbox item using cached dictionary
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve</param>
		private DslDesign::ModelingToolboxItem GetToolboxItem(string itemId)
		{
			DslDesign::ModelingToolboxItem item = null;

			if (!this.toolboxItemCache.TryGetValue(itemId, out item))
			{
				DslModeling::Store store = this.ToolboxStore;
				
				// Open transaction so we can create model elements corresponding to toolbox items.
				using (DslModeling::Transaction t = store.TransactionManager.BeginTransaction("CreateToolboxItems"))
				{
					// Retrieve the specified ToolboxItem from the DSL
					this.toolboxItemCache[itemId] = item = this.GetToolboxItem(itemId, store);
				}
			}

			return item;
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		public virtual object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			DslDesign::ModelingToolboxItem item = null;

			global::System.Resources.ResourceManager resourceManager = global::CQRSAzure.CQRSdsl.Dsl.CQRSdslDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;

			System.Windows.Forms.IDataObject tbxDataObj;

			//get the toolbox item
			item = GetToolboxItem(itemId);

			if (item != null)
			{
				ToolboxItemContainer container = new ToolboxItemContainer(item);
				tbxDataObj = container.ToolboxData;

				if (tbxDataObj.GetDataPresent(format.Name))
				{
					return tbxDataObj.GetData(format.Name);
				}
				else 
				{
					string invalidFormatString = resourceManager.GetString("UnsupportedToolboxFormat", resourceCulture);
					throw new InvalidOperationException(string.Format(resourceCulture, invalidFormatString, format.Name));
				}
			}

			string errorFormatString = resourceManager.GetString("UnresolvedToolboxItem", resourceCulture);
			throw new InvalidOperationException(string.Format(resourceCulture, errorFormatString, itemId));
		}		
	}
}
