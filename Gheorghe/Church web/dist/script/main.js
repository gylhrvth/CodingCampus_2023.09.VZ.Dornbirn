"use strict";
// src/scripts/main.ts
var PhotoCarousel = /** @class */ (function () {
    function PhotoCarousel(photos) {
        this.photos = photos;
    }
    PhotoCarousel.prototype.displayPhotos = function () {
        var photoContainer = document.getElementById('photo-container');
        if (photoContainer) {
            this.photos.forEach(function (photo) {
                var img = document.createElement('img');
                img.src = photo;
                photoContainer.appendChild(img);
            });
        }
    };
    return PhotoCarousel;
}());
// Example usage
var photoUrls = ["url1.jpg", "url2.jpg", "url3.jpg"];
var carousel = new PhotoCarousel(photoUrls);
carousel.displayPhotos();
