# ASMD2-1670

Index.cshtml

@{
    ViewData["Title"] = "Home Page";
}

<div class="text-center">

    <h1 class="display-4">Welcome to FPT BOOK STORE</h1>

</div>
<div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="true">
    <div class="carousel-indicators">
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
    </div>
    <div class="carousel-inner">
        <div class="carousel-item active">
            <img src="https://media.istockphoto.com/id/1018141798/photo/back-to-school-backgrounds-for-girl-white-and-pink-stationery-books-on-white-wood-table-and.jpg?s=170667a&w=0&k=20&c=u5FPqo9VpDud_KzvxgGadGuhPJs7b3h_TBlSe_yYoAU=" class="d-block w-100" alt="...">
        </div>
        <div class="carousel-item">
            <img src="https://d1e00ek4ebabms.cloudfront.net/production/77b41724-a1a7-464f-8135-fc7e0f7cec12.jpg" class="d-block w-100" alt="...">
        </div>
        <div class="carousel-item">
            <img src="https://images.unsplash.com/photo-1588580000645-4562a6d2c839?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Ym9vayUyMHNoZWxmfGVufDB8fDB8fA%3D%3D&w=1000&q=80" class="d-block w-100" alt="...">
        </div>
    </div>
    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
    </button>
    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
    </button>
</div>
