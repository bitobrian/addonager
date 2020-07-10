using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace addonager
{
    public class AddonVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Interface
        //Specifies which client interface version the addon was made for. If the value of this tag does not match the client interface version, the addon is loaded only if the "Load out of date addons" option is enabled.There are a number of ways to determine the current interface version.
        //## Interface: 80205
        private string _interface { get; set; }
        public string Interface
        {
            get { return _interface; }
            set
            {
                _interface = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }

        //Title
        //The value of this tag is displayed in the AddOns list.Localized versions can be included by appending a hyphen followed by the client locale name; the client automatically chooses a localized version if one is available.The value may also contain UI escape sequences, such as for example colors.
        //## Title: Waiting for Godot
        //## Title-frFR: En attendant Godot
        private string _title { get; set; }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }

        //Version
        //The AddOn version.Some automatic updating tools may prefer that this string begins with a numeric version number.
        private string _version { get; set; }
        public string Version
        {
            get { return _version; }
            set
            {
                _version = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }


        //Notes
        //Addon description that appears when the user hovers over the addon entry in the addons list.Like Title, this tag can be localized by appending a hyphen followed by locale name, and contain UI escape sequences.
        //## Notes: "Nothing to be done"

        //RequiredDeps, Dependencies, or any word beginning with "Dep"
        //A comma-separated list of addon (directory) names that must be loaded before this addon can be loaded.
        // ## Dependencies: someAddOn, someOtherAddOn

        //OptionalDeps
        //A comma-separated list of addon (directory) names that should be loaded before this addon if they can be loaded.
        //## OptionalDeps: someAddOn, someOtherAddOn

        //LoadOnDemand
        //If the value of this tag is "1", the addon is not loaded when the user first logs in, but can be loaded by another addon at a later point.This can be used to avoid loading situational addons.
        //## LoadOnDemand: 1

        //LoadWith
        //A comma-separated list of addon (directory) names that, when loaded, will cause the client to load this LoadOnDemand addon as well.Added in Patch 1.9
        //## LoadWith: someAddOn, someOtherAddOn

        //LoadManagers
        //A comma-separated list of addon (directory) names; if no addons on this list are loaded, the client will load your addon when the user logs in; if at least one addon on this list is loaded, your addon is treated as LoadOnDemand.Introduced in patch 2.1; an example of a LoadManager is AddonLoader.

        //SavedVariables
        //A comma-separated list of variable names in the global environment that will be saved to disk when the client exits, and placed back into the global environment when your addon is loaded; the variables are not available before the ADDON_LOADED event fires for your addon. See Saving variables between game sessions.
        //## SavedVariables: foo, bar

        //SavedVariablesPerCharacter
        //A comma-separated list of variable names in the global environment that will be saved to disk when the client exits, and placed back into the global environment when your addon is loaded for a particular character. Note that PerCharacter saved variables are only loaded for the character for which they were saved.
        //## SavedVariablesPerCharacter: somePercharVariable

        //DefaultState
        //Determines whether the addon is enabled by default when first installed. If the value of this tag is "disabled", the user must explicitly enable the addon in the addons list before it is loaded.
        //## DefaultState: enabled

        //Secure
        //If the value of this tag is 1, and the addon is digitally signed by Blizzard, its code is considered secure (as opposed to tainted, which is what all 3rd-party addons are). Introduced in Patch 1.11.

        //Author
        //The AddOn author's name


        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string caller = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
