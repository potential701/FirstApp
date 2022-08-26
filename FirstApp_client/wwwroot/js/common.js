﻿window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'operation successful', { timeOut: 5000 });
    }
    if (type === "error") {
        toastr.error(message, 'operation failed', { timeOut: 5000 });
    }
}

window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Success Notification!',
            message,
            'success'
        )
    }
    if (type === "error") {
        Swal.fire(
            'Error Notification!',
            message,
            'error'
        )
    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}