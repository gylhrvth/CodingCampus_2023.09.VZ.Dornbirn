class PhotoCarousel {
    private photos: string[];

    constructor(photos: string[]) {
        this.photos = photos;
    }

    displayPhotos() {
        const photoContainer = document.getElementById('photo-container');
        if (photoContainer) {
            this.photos.forEach(photo => {
                const img = document.createElement('img');
                img.src = photo;
                photoContainer.appendChild(img);
            });
        }
    }
}

// Example usage
const initializeCarousel = () => {
    const photoUrls: string[] = ["url1.jpg", "url2.jpg", "url3.jpg"];
    const carousel = new PhotoCarousel(photoUrls);
    carousel.displayPhotos();
};

// Call the function to initialize the carousel
initializeCarousel();
