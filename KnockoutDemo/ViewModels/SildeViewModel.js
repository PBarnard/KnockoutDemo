/// <reference path="C:\Users\Paul\Source\Repos\KnockoutDemo\KnockoutDemo\Scripts/jquery-1.10.2.min.js" />
/// <reference path="C:\Users\Paul\Source\Repos\KnockoutDemo\KnockoutDemo\Scripts/knockout-3.3.0.js" />

function SlideViewModel() {
    // Get the reference to self
    var self = this;

    // Create observable properties
    self.Provider = window.ko.observable();
    self.ReferenceNumber = window.ko.observable();
    self.SlideType = window.ko.observable();
    self.From = window.ko.observable();
    self.To = window.ko.observable();

    self.addSlide = function() {
        $.ajax({
            url: "/api/Slide/",
            type: "post",
            data: window.ko.toJSON(this),
            contentType: "application/json",
            success: function() {}
        });
    };

    // Get the data from the API and bind to properties
    $.getJSON("/api/Slide/").done(function (data) {
        self.Provider(data.Provider);
        self.ReferenceNumber(data.ReferenceNumber);
        self.SlideType(data.SlideType);
        self.From(data.From);
        self.To(data.To);
    });
}

// Apply bindings
ko.applyBindings(new SlideViewModel());