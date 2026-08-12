define("Contacts_ListPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "LookupQuickFilterByTag",
				"values": {
					"config": {
						"caption": "#ResourceString(LookupQuickFilterByTag_config_caption)#",
						"hint": "#ResourceString(LookupQuickFilterByTag_config_hint)#",
						"icon": "tag-icon",
						"iconPosition": "left-icon",
						"entitySchemaName": null,
						"defaultValue": []
					},
					"_filterOptions": {
						"expose": [],
						"from": "LookupQuickFilterByTag_Value"
					}
				}
			},
			{
				"operation": "merge",
				"name": "SearchFilter",
				"values": {
					"_filterOptions": {
						"expose": [],
						"from": [
							"SearchFilter_SearchValue",
							"SearchFilter_FilteredColumnsGroups"
						]
					}
				}
			},
			{
				"operation": "merge",
				"name": "FolderTree",
				"values": {
					"_filterOptions": {
						"expose": [],
						"from": [
							"FolderTree_items",
							"FolderTree_favoriteItems",
							"FolderTree_active_folder_id"
						]
					}
				}
			},
			{
				"operation": "merge",
				"name": "Filters",
				"values": {
					"_filterOptions": {
						"expose": [],
						"from": "Filters_Value"
					}
				}
			},
			{
				"operation": "remove",
				"name": "DataTable"
			},
			{
				"operation": "remove",
				"name": "DataTable_AddTagsBulkAction"
			},
			{
				"operation": "remove",
				"name": "DataTable_RemoveTagsBulkAction"
			},
			{
				"operation": "remove",
				"name": "DataTable_ExportToExcelBulkAction"
			},
			{
				"operation": "remove",
				"name": "DataTable_MergeBulkAction"
			},
			{
				"operation": "remove",
				"name": "DataTable_DeleteBulkAction"
			},
			{
				"operation": "merge",
				"name": "Dashboards",
				"values": {
					"_designOptions": {
						"entitySchemaName": "Contact",
						"dependencies": [],
						"filters": []
					}
				}
			},
			{
				"operation": "insert",
				"name": "DataGrid_lxlwy3g",
				"values": {
					"type": "crt.DataGrid",
					"columns": [
						{
							"id": "9fd3fbba-586a-df9b-522c-6018f01a2d6b",
							"code": "DataGrid_lxlwy3gDS_Name",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_Name)#",
							"dataValueType": 1,
							"sticky": true
						},
						{
							"id": "0a540855-5e56-d000-fdad-af01b7929e87",
							"code": "DataGrid_lxlwy3gDS_Type",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_Type)#",
							"dataValueType": 10,
							"width": 186
						},
						{
							"id": "719f7461-23bc-ce7c-2639-301795c1e010",
							"code": "DataGrid_lxlwy3gDS_Account",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_Account)#",
							"dataValueType": 10
						},
						{
							"id": "e64b61f6-7be7-e998-8e71-a92313baac62",
							"code": "DataGrid_lxlwy3gDS_MobilePhone",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_MobilePhone)#",
							"dataValueType": 28,
							"width": 187
						},
						{
							"id": "981d0775-67e3-41f5-d8ce-ad04137b609d",
							"code": "DataGrid_lxlwy3gDS_Email",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_Email)#",
							"dataValueType": 28,
							"width": 161
						},
						{
							"id": "f2b7b990-99d2-94e9-d5bd-03838a5b30df",
							"code": "DataGrid_lxlwy3gDS_Country",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_Country)#",
							"dataValueType": 10,
							"width": 158
						},
						{
							"id": "8d552674-71cb-eb69-a657-2bb03b61f280",
							"code": "DataGrid_lxlwy3gDS_BirthDate",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_BirthDate)#",
							"dataValueType": 8,
							"width": 127
						},
						{
							"id": "57d7c21e-2697-61f6-8066-6c9ce8cb0dd5",
							"code": "DataGrid_lxlwy3gDS_Address",
							"caption": "#ResourceString(DataGrid_lxlwy3gDS_Address)#",
							"dataValueType": 29
						}
					],
					"items": "$DataGrid_lxlwy3g",
					"classes": [
						"section-data-grid"
					],
					"features": {
						"rows": {
							"selection": {
								"enable": true,
								"multiple": true
							}
						}
					},
					"primaryColumnName": "DataGrid_lxlwy3gDS_Id",
					"fitContent": true,
					"layoutConfig": {
						"basis": "100%"
					}
				},
				"parentName": "ListContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"DataGrid_lxlwy3g": {
						"isCollection": true,
						"modelConfig": {
							"path": "DataGrid_lxlwy3gDS",
							"pagingConfig": {
								"rowCount": 30
							},
							"sortingConfig": {
								"attributeName": "ItemsSorting",
								"default": [
									{
										"direction": "desc",
										"columnName": "Address"
									}
								]
							}
						},
						"viewModelConfig": {
							"attributes": {
								"DataGrid_lxlwy3gDS_Name": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.Name"
									}
								},
								"DataGrid_lxlwy3gDS_Type": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.Type"
									}
								},
								"DataGrid_lxlwy3gDS_Account": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.Account"
									}
								},
								"DataGrid_lxlwy3gDS_MobilePhone": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.MobilePhone"
									}
								},
								"DataGrid_lxlwy3gDS_Email": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.Email"
									}
								},
								"DataGrid_lxlwy3gDS_Country": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.Country"
									}
								},
								"DataGrid_lxlwy3gDS_BirthDate": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.BirthDate"
									}
								},
								"DataGrid_lxlwy3gDS_Address": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.Address"
									}
								},
								"DataGrid_lxlwy3gDS_Id": {
									"modelConfig": {
										"path": "DataGrid_lxlwy3gDS.Id"
									}
								}
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Items",
					"viewModelConfig",
					"attributes"
				],
				"values": {
					"PDS_Address": {
						"modelConfig": {
							"path": "PDS.Address"
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Items",
					"modelConfig"
				],
				"values": {
					"filterAttributes": []
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Items",
					"modelConfig",
					"sortingConfig"
				],
				"values": {
					"default": [
						{
							"direction": "desc",
							"columnName": "Type"
						}
					]
				}
			},
			{
				"operation": "merge",
				"path": [
					"attributes",
					"ItemsSorting"
				],
				"values": {
					"modelConfig": {}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources"
				],
				"values": {
					"DataGrid_lxlwy3gDS": {
						"type": "crt.EntityDataSource",
						"scope": "viewElement",
						"config": {
							"entitySchemaName": "Contact",
							"attributes": {
								"Name": {
									"path": "Name"
								},
								"Type": {
									"path": "Type"
								},
								"Account": {
									"path": "Account"
								},
								"MobilePhone": {
									"path": "MobilePhone"
								},
								"Email": {
									"path": "Email"
								},
								"Country": {
									"path": "Country"
								},
								"BirthDate": {
									"path": "BirthDate"
								},
								"Address": {
									"path": "Address"
								}
							}
						}
					}
				}
			},
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"PDS",
					"config",
					"attributes"
				],
				"values": {
					"Address": {
						"path": "Address"
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});