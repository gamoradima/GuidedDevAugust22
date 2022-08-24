define("UsrRealtyVisitDetailGrid", ["LookupMultiAddMixin"], function() {
	return {
		entitySchemaName: "UsrRealtyVisit",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		mixins: {
            /* Enable the mixin in the schema. */
            LookupMultiAddMixin: "Terrasoft.LookupMultiAddMixin"
        },
		messages: {
			"GetRealtySkillId": {
        		mode: Terrasoft.MessageMode.PTP,
        		direction: Terrasoft.MessageDirectionType.PUBLISH
		    },
		},

		methods: {
			init: function() {
				this.callParent(arguments);
				this.subscribeForWebsocketEvents();
				// Click on "+" and add multi records example
				this.mixins.LookupMultiAddMixin.init.call(this);
				
				this.sandbox.registerMessages(this.messages);

			},
			destroy: function() {
				this.callParent(arguments);
				this.unsubscribeForWebsocketEvents();
			},
			subscribeForWebsocketEvents: function() {
				this.Terrasoft.ServerChannel.on(this.Terrasoft.EventName.ON_MESSAGE,
					this.onWebsocketMessage, this);
			},
			unsubscribeForWebsocketEvents: function() {
				this.Terrasoft.ServerChannel.un(this.Terrasoft.EventName.ON_MESSAGE,
					this.onWebsocketMessage, this);
			},
			
			onWebsocketMessage: function(scope, message) {
				if (!message) {
					return;
				}
				if (!message.Header) {
					return;
				}
				if (message.Header.Sender !== "AutoAddVisits") {
					return;
				}
				this.reloadGridData();
			},

            /* Override the base method that displays the addition button. */
            getAddRecordButtonVisible: function() {
                /* Display the addition button if the detail is expanded regardless of whether you implemented the record page for the detail. */
                return this.getToolsVisible();
            },
            /* Override the base method.
            Handles the save event of the detail record page. */
            /*onCardSaved: function() {
               
                this.openLookupWithMultiSelect();
            },*/
            /* Override the base method that adds records to the detail. */
            addRecord: function() {
                /* Open the multiple selection dialog box. */
                this.openLookupWithMultiSelect(true);
            },
            /* The method that returns the configuration object for the dialog box. */
            getMultiSelectLookupConfig: function() {
                return {
                    /* Set the parent entity schema to [Opportunity]. */
                    rootEntitySchemaName: "UsrRealty",
                    /* The root schema column. */
                    rootColumnName: "UsrParentRealty",
                    /* Set the connected schema to [Contact]. */
                    relatedEntitySchemaName: "Contact",
                    /* The connected schema column. */
                    relatedColumnName: "UsrManager"
                };
            },
			
			getAdditionalLookupFilters: function() {
				var filterGroup = Ext.create("Terrasoft.FilterGroup");

				var subFilters = this.Terrasoft.createFilterGroup();
				var skillId = this.sandbox.publish("GetRealtySkillId", null, []);
				if (skillId) {
					subFilters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "UsrSkill", skillId));
					var filter = Terrasoft.createExistsFilter("[UsrContactSkill:UsrParentContact:Id].Id", subFilters); 
					filterGroup.add("MainFilter", filter);
				}
				return filterGroup;
			}
			
			
		}
	};
});
