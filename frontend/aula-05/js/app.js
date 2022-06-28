const TBODY = document.querySelector('tbody');


document.querySelector('form').addEventListener('submit', function(e){
    e.preventDefault();

    const CAMPOS = [
        document.querySelector('#usuario'),
        document.querySelector('#email'),
        document.querySelector('#dataCadastro'),
        document.querySelector('#tipoConta')
    ];
    // alert('Cancelou');
    const TR = document.createElement('tr');
    //const TD = document.createElement('td');

    CAMPOS.forEach((campo) => {
        const TD = document.createElement('td');

        TD.textContent = campo.value;
        TR.appendChild(TD);
    });

    TBODY.appendChild(TR);

    this.reset();
});