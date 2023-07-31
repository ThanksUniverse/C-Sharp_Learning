// Função para verificar o valor do crachá e mostrar as opções se for um número válido
document.getElementById("cracha").addEventListener("input", function () {
    const crachaValue = this.value;
    const colaborador = document.getElementById("colaborador");
    const opcoesDiv = document.getElementById("opcoes");

    if (crachaValue > 100) {
        colaborador.value = "Pedro";
        opcoesDiv.style.display = "block";
    }
});