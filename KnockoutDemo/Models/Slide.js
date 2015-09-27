(function(knockoutDemo) {

    // Slide constructor function
    function Slide() {

        // Get the reference to self
        var self = this;

        // Define properties
        self.Provider = window.ko.observable("");
        self.ReferenceNumber = window.ko.observable("");
        self.SlideType = window.ko.observable("");
        self.From = window.ko.observable("");
        self.To = window.ko.observable("");

    }

    // Add to the namespace
    knockoutDemo.Slide = Slide;

} (window.knockoutDemo));