define("ArtemTerziShowAveragePricePage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "ArtemTerziAveragePriceParameter",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.NumberInput",
					"label": "$Resources.Strings.NumberAttribute_lcbaefo",
					"labelPosition": "auto",
					"control": "$NumberAttribute_lcbaefo",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "GeneralInfoTabContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "RichTextEditor_99z7c61",
				"values": {
					"type": "crt.RichTextEditor",
					"label": "$Resources.Strings.StringAttribute_mj3ws82",
					"labelPosition": "auto",
					"control": "$StringAttribute_mj3ws82",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"tooltip": "",
					"toolbarDisplayMode": null
				},
				"parentName": "GeneralInfoTab",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfig: /**SCHEMA_VIEW_MODEL_CONFIG*/{
			"attributes": {
				"NumberAttribute_lcbaefo": {
					"modelConfig": {
						"path": "PageParameters.ArtemTerziAveragePriceParameter"
					}
				},
				"StringAttribute_mj3ws82": {
					"modelConfig": {
						"path": "PageParameters.ArtemTerziRichTextParameter1"
					}
				}
			}
		}/**SCHEMA_VIEW_MODEL_CONFIG*/,
		modelConfig: /**SCHEMA_MODEL_CONFIG*/{}/**SCHEMA_MODEL_CONFIG*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});