document.addEventListener("DOMContentLoaded", function () {
    // Mensaje de bienvenida solo una vez por sesión
    if (!sessionStorage.getItem('bienvenidaMostrada')) {
        Swal.fire({
            toast: true,
            position: 'top-end',
            icon: 'success',
            title: 'Bienvenido al sistema',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true
        });
        sessionStorage.setItem('bienvenidaMostrada', 'true');
    }

    // Advertencia por conexión lenta
    if (navigator.connection && navigator.connection.downlink < 0.8) {
        Swal.fire({
            icon: 'question',
            title: '¿Conexión lenta?',
            text: 'Tu conexión a internet parece ser lenta.',
            confirmButtonColor: '#0d6efd'
        });
    }

    // Inicia actualización de fecha y hora en navbar
    actualizarFechaHoraNavbar();
    setInterval(actualizarFechaHoraNavbar, 1000);
});

// Loader
window.addEventListener("load", () => {
    const loader = document.getElementById("loader-wrapper");
    if (loader) {
        setTimeout(() => {
            loader.classList.add("fade-out");
        }, 300);
    }
});

// Mostrar fecha y hora detallada con SweetAlert2
function mostrarFechaHoraCompleta() {
    const ahora = new Date();

    const opcionesLargas = {
        weekday: 'long',
        year: 'numeric',
        month: 'long',
        day: 'numeric',
        hour: 'numeric',
        minute: '2-digit',
        second: '2-digit',
        timeZoneName: 'short'
    };

    const detalle = ahora.toLocaleString('es-CR', opcionesLargas);

    Swal.fire({
        icon: 'info',
        title: 'Fecha y hora detallada',
        html: `<b>${detalle}</b>`,
        confirmButtonColor: '#0d6efd'
    });
}

// Mostrar hora y fecha resumen en navbar
function actualizarFechaHoraNavbar() {
    const horaTexto = document.getElementById('horaTextoNavbar');
    if (!horaTexto) return;

    const ahora = new Date();
    const opcionesFecha = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric' };
    const fecha = ahora.toLocaleDateString('es-CR', opcionesFecha);
    const hora = ahora.toLocaleTimeString('es-CR');

    horaTexto.textContent = `${fecha} | ${hora}`;
}

// Confirmación reutilizable
function confirmarAccion(titulo, texto, icono, callback) {
    Swal.fire({
        title: titulo,
        text: texto,
        icon: icono,
        showCancelButton: true,
        confirmButtonText: 'Confirmar',
        cancelButtonText: 'Cancelar',
        confirmButtonColor: '#0d6efd',
        cancelButtonColor: '#6c757d'
    }).then((result) => {
        if (result.isConfirmed && typeof callback === 'function') {
            callback();
        }
    });
}
