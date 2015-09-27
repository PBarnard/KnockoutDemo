/// <reference path="C:\Users\Paul\Source\Repos\KnockoutDemo\KnockoutDemo\Scripts/jquery-1.10.2.min.js" />
/// <reference path="C:\Users\Paul\Source\Repos\KnockoutDemo\KnockoutDemo\Scripts/knockout-3.3.0.js" />

(function (knockoutDemo) {

    function SlideViewModel() {

        // Get the reference to self
        var self = this;

        // Create Slide property
        self.Slide = new window.knockoutDemo.Slide();

        // 
        self.addSlide = function() {
            $.ajax({
                url: "/api/Slide/",
                type: "post",
                data: window.ko.toJSON(self.Slide),
                contentType: "application/json",
                success: function () { },
                error: function(xhr, status, error) {
                    alert(xhr.responseJSON.Message);
                }
            });
        };

        // Get the data from the API and bind to properties
        $.getJSON("/api/Slide/").done(function(data) {
            self.Slide.Provider(data.Provider);
            self.Slide.ReferenceNumber(data.ReferenceNumber);
            self.Slide.SlideType(data.SlideType);
            self.Slide.From(data.From);
            self.Slide.To(data.To);
        });
    }

    knockoutDemo.SlideViewModel = SlideViewModel;

}(window.knockoutDemo));
