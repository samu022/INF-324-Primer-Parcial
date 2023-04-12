<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="p2.Quimica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <!-- mobile metas -->
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <meta name="viewport" content="initial-scale=1, maximum-scale=1">
      <!-- site metas -->
      <title>Facultad de Ciencias Puras y Naturales</title>
      <meta name="keywords" content="">
      <meta name="description" content="">
      <meta name="author" content="">
      <!-- owl carousel style -->
      <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.0.0-beta.2.4/assets/owl.carousel.min.css" />
      <!-- bootstrap css -->
      <link rel="stylesheet" type="text/css" href="../css/bootstrap.min.css">
      <!-- style css -->
      <link rel="stylesheet" type="text/css" href="../css/style.css">
      <!-- Responsive-->
      <link rel="stylesheet" href="../css/responsive.css">
      <!-- fevicon -->
      <link rel="icon" href="../images/fevicon.png" type="image/gif" />
      <!-- Scrollbar Custom CSS -->
      <link rel="stylesheet" href="../css/jquery.mCustomScrollbar.min.css">
      <!-- Tweaks for older IEs-->
      <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css">
      <!-- fonts -->
      <link href="https://fonts.googleapis.com/css?family=Open+Sans:400,700|Poppins:400,700&display=swap" rel="stylesheet">
      <!-- owl stylesheets --> 
      <link rel="stylesheet" href="../css/owl.carousel.min.css">
      <link rel="stylesheet" href="../css/owl.theme.default.min.css">
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css" media="screen">
    <style> 
           .boton-container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100%;
            }

            .boton-centrado {
            margin: auto;
            }

       </style>
</head>
<body>
    <form id="form1" runat="server">
        <!--SESION-->
        <div>
            <asp:Label ID="lblBienvenida" runat="server" Text="" CssClass="h3"></asp:Label>
        </div>
        <!--CERRAR SESION-->
        <div style="position: absolute;top: 10px;right: 10px; margin: 0;">
            <asp:Button ID="BtnCerrar" runat="server" Text="Cerrar Sesion" OnClick="BtnCerrar_Click"/>
        </div>
        
     <!--header section start -->
      <div class="header_section">
         <div class="header_bg">
            <div class="container">
               <nav class="navbar navbar-expand-lg navbar-light bg-light">
                  <a class="logo" href="index.php"><img src="../images/logo1.png"></a>
                  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                  <span class="navbar-toggler-icon"></span>
                  </button>
                  <div class="collapse navbar-collapse" id="navbarSupportedContent">
                     <ul class="navbar-nav mr-auto">
                        <li class="nav-item active">
                           <a class="nav-link" href="../index.aspx">Home</a>
                        </li>
                         <!--AGREGAMOS EL BOTON PARA EL ROL DIRECTOR-->
                        <li class="nav-item active" runat="server" id="BtnDirector" style="background-color: #0B8DB0; color: white;">
                           <a class="nav-link" href="promedios.aspx">Promedios (Director)</a>
                        </li>
                        <li class="nav-item">
                           <a class="nav-link" href="../Informatica/index.aspx">Carrera de Informatica</a>
                        </li>
                        <li class="nav-item">
                           <a class="nav-link" href="../Fisica/index.aspx">Carrera de Física</a>
                        </li>
                        <li class="nav-item">
                           <a class="nav-link" href="../Quimica/index.aspx">Carrera de Química</a>
                        </li>
                        <li class="nav-item">
                           <a class="nav-link" href="../contact.aspx">Contacto</a>
                        </li>
                     </ul>
                     <div class="call_section">
                        <ul>
                           <li><a href="https://www.facebook.com/fcpn.umsa"><img src="../images/fb-icon.png"></a></li>
                           <li><a href="https://twitter.com/fcpn_umsa?lang=es"><img src="../images/twitter-icon.png"></a></li>
                           <li><a href="#"><img src="../images/linkedin-icon.png"></a></li>
                           <li><a href="#"><img src="../images/instagram-icon.png"></a></li>
                           <div class="donate_bt"><a href="#"><img src="../images/search-icon.png"></a></div>
                        </ul>
                     </div>
                  </div>
               </nav>
            </div>
         </div>

          <!--banner section start -->
      <div class="banner_section layout_padding">
         <div id="my_slider" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
               <div class="carousel-item active">
                  <div class="container">
                     <div class="banner_taital_main">
                        <div class="row">
                           <div class="col-md-6">
                              <h1 class="banner_taital">Bienvenido a la Carrera de Química</h1>
                              <p class="banner_text">Universidad Mayor de San Andrés</p>
                              <div class="btn_main">
                                 <div class="about_bt active"><a href="#">Acerca de nosotros</a></div>
                                 <div class="quote_bt"><a href="#">Ubicación</a></div>
                              </div>
                           </div>
                           <div class="col-md-6">
                              <div class="image_1"><img src="../images/quimica2.png"></div>
                           </div>
                        </div>
                     </div>
                  </div>
               </div>
               
               
            </div>
     
         </div>
      </div>

      <!-- texto-->
      <div class="cuerpo">
      		<img src="../images/logoqui.png" style="display: block; margin: auto;"><br/>
      		<h1>Objetivos de la carrera de química</h1>
      		<p>Planificar, dirigir, evaluar y efectuar estudios e investigaciones referidos a las sustancias constitutivas de la materia inanimada y viviente, sus combinaciones, sistemas, sus estructuras y propiedades, sus variaciones y las leyes y procesos que rigen sus interacciones, transformaciones y comportamientos.</p>
      		<h2>¿Qué es la química?</h2>
      		<p>La química es la ciencia que se encarga del estudio de la estructura, composición y propiedades de la materia, así como las transformaciones que ésta experimenta durante las reacciones químicas.<br/>

La química se enfoca en la comprensión de los átomos, las moléculas, los iones y otras partículas subatómicas, y en cómo interactúan para formar compuestos químicos y otros materiales. Esta ciencia abarca desde la comprensión de los procesos químicos básicos a nivel molecular hasta la síntesis de nuevos compuestos, y su aplicación en la producción de nuevos materiales y productos, así como en la exploración y el descubrimiento de nuevos medicamentos y terapias.<br/>

La química tiene una amplia variedad de aplicaciones en campos como la medicina, la industria, la agricultura, la energía, la tecnología de materiales y la nanotecnología, y es fundamental para la comprensión de muchos procesos naturales y artificiales que se llevan a cabo en la Tierra. La química también tiene una fuerte conexión con otras disciplinas científicas, como la física y la biología, y su estudio es fundamental para entender muchos de los fenómenos naturales que nos rodean y que afectan nuestra vida diaria.</p>
      </div>

          <!-- contact section end -->
      <!-- footer section start -->
      <div class="footer_section layout_padding">
         <div class="container">
            <div class="subscribe_bt"><a href="#">Suscribirse</a></div>
            <input type="text" class="email_text" placeholder="Ingrese su email" name="Enter Your Email">
            <div class="footer_section_2">
               <div class="row">
                  <div class="col-lg-3 margin_top">
                     <div class="call_text"><a href="#"><img src="../images/call-icon1.png"><span class="padding_left_15">Llama ahora (591-2) 2441570 / 2440571</span></a></div>
                     <div class="call_text"><a href="#"><img src="../images/mail-icon1.png"><span class="padding_left_15">decanato@fcpn.edu.bo</span></a></div>
                  </div>
                  <div class="col-lg-3">
                     <div class="information_main">
                        <h4 class="information_text">Información</h4>
                        <p class="many_text">La FCPN de la UMSA también es conocida por su contribución al desarrollo de la ciencia y la tecnología en Bolivia, y ha sido reconocida por su importante papel en la formación de profesionales altamente capacitados y en la producción de investigaciones científicas relevantes para el país y la región.</p>
                     </div>
                  </div>
                  <div class="col-lg-3 col-md-6">
                     <div class="information_main">
                        <h4 class="information_text">Links de ayuda</h4>
                        <div class="footer_menu">
                           <ul>
                              <li><a href="../index.aspx">Home</a></li>
                              <li><a href="../Informatica/index.aspx">Carrera de Informática</a></li>
                              <li><a href="../Fisica/index.aspx">Carrera de Física</a></li>
                              <li><a href="../Quimica/index.aspx">Carrera de Química</a></li>
                              <li><a href="../contact.aspx">Contacto</a></li>
                           </ul>
                        </div>
                     </div>
                  </div>
                  <div class="col-lg-3">
                     <div class="information_main">
                        <div class="footer_logo"><a href="../index.php"><img src="../images/footer-logo1.png"></a></div>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- footer section end -->
      <!-- copyright section start -->
      <div class="copyright_section">
         <div class="container">
            <p class="copyright_text">© 2023 All Rights Reserved. <a href="https://html.design">Realizado por: Samuel Alegre Flores</a></p>
         </div>
      </div>
      <!-- copyright section end -->
      <!-- Javascript files-->
      <script src="../Scripts/jquery.min.js"></script>
      <script src="../Scripts/popper.min.js"></script>
      <script src="../Scripts/bootstrap.bundle.min.js"></script>
      <script src="../Scripts/jquery-3.0.0.min.js"></script>
      <script src="../Scripts/plugin.js"></script>
      <!-- sidebar -->
      <script src="../Scripts/jquery.mCustomScrollbar.concat.min.js"></script>
      <script src="../Scripts/custom.js"></script>
      <!-- javascript --> 
      <script src="../Scripts/owl.carousel.js"></script>
      <script src="https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js"></script>
    </form>
</body>
</html>
