using System;
using static System.Console;

namespace IlhaDoTesouro {
    class Program {
        public static void Main(string[] args) {
            WriteLine("           Ilha do Tesouro           ");
            WriteLine("-------------------------------------");
            WriteLine();
            WriteLine("Após você chega a praia e dar uma olhada no mapa para confirmar se esta no lugar certo.");
            WriteLine("Vê partes da paisagem semelhante com as do desenho do map.");
            WriteLine("Voltando a olhar para a praia se depara com um quiosque meio macabro");
            Write("Você vai até ele? Ou não? {S/N}: ");
            string resp1 = ReadLine();
            if (resp1 == "s" || resp1 == "S") {
                WriteLine("O atendente com uma aparencia amigavel te comprimenta.");
            }
            else {
                WriteLine("Você decidiu caminhar um pouco. Ficando aderia pela praia e acaba caindo em um buraco.");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }

            WriteLine();
            WriteLine("Vocês começão uma convervar ele te explicando sobre os mistérios da area te conta as historias urbanas, te");
            WriteLine("fala de uma ilha secreta que aparece a cada 100 anos, e esse ano é um desses.");
            Write("No meio da conversa ele te oferece uma bebida de coloração estranha você aceita? {S/N}: ");
            string resp2 = ReadLine();
            if (resp2 == "S" || resp2 == "s") {
                WriteLine("Você a aproxima do rosto e por causa do forte odor acaba desmaiando.");
            }
            else {
                WriteLine("Você recusa a bebida, a conversa continua tranquila e chega ao fim, no momento que você esta se retirando sente uma pontada inesperada nas costa ao se virar ve o atendente com uma faca na mão dizendo:");
                WriteLine("O senhor sabe demais..........Sua vista vai escurecendo o você morre.");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }
            WriteLine();
            WriteLine("Quando você acorda sente um balanço estranho, quanto mais acordado está ficando começa a perceber estar em uma embarcação.");
            WriteLine("Ao olhar em volta com a vista um pouco embaçada por causa dos efeitos, acaba percebem estar em uma cela.");
            WriteLine("Escutando alguém bater na cela, você desperta. O guarda pergunta seu nome.");
            Write("Voce responde ? Ou não? {S/N}: ");
            string resp3 = ReadLine();
            if (resp3 == "S" || resp2 == "s") {
                WriteLine("Uma conversa é iniciada, o guarda acaba gostando de você assim abaixando a guarda chegando cada vez mais proximo da cela.");
            }
            else {
                WriteLine("Você escolhe o silencio....... A embarcação segue seu curso até o mercado de escravos você foi vendido");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }
            WriteLine();
            WriteLine("A conversa se estende te deixando com sede, pedindo uma água o guarda busca e te entrega");
            Write("Você puxa o braço do guarda? {S/N}: ");
            string resp4 = ReadLine();
            if (resp4 == "S" || resp4 == "s") {
                WriteLine("O guarda bate a cabeça nas grades e fica inconsciente......Você rouba as chaves e abre a cela.");
            }
            else {
                WriteLine("Ao beber a água a conversa continua, o guarde se cansa e vai embora.");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }
            WriteLine();
            WriteLine("Ao sair da cela um barulho de passos é escutado no corredor...... olhando em volta a três saidas possiveis");
            Write("Uma janela e duas portas: Janela {1}, Quarto 1 {2}, Quarto 2 {3}. Escolha uma opção: ");
            int resp5 = int.Parse(Console.ReadLine());
            if (resp5 == 1) {
                WriteLine("Janela foi escolhida...... Você caiu no mar");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }
            else if (resp5 == 2) {
                WriteLine("Quarto 1 foi escolhido...... Você entrou no dormitorio.");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }
            else {
                WriteLine("Quarto 2 foi escolhido...... Você entrou na sala de armas e munições.");
            }
            WriteLine();
            WriteLine("Olhando em volta é visto barris uma escada para o convés e um alçapão.");
            WriteLine("Para qual direção você vai se esconde atras dos barris? Sobe para o convés? Vai para o alçapão?");
            Write("Barris {B}, Convés {C}, Alçapão {A}. Escolha uma opção: ");
            string resp6 = ReadLine();
            if (resp6 == "B" || resp6 == "b") {
                WriteLine("Barris foi escolhido....... Você pega uma pistola e se esconde.");
                WriteLine("O segundo guarda entra te procurando, do escoderijo você atira o matando assim todos no barco escutam.");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }
            else if (resp6 == "C" || resp6 == "c") {
                WriteLine();
            }
            else {
                WriteLine("Alçapão foi escolhido....... Você caiu na parte mais inferior do navio.");
                WriteLine("-------------------------------------");
                WriteLine("           Game Over           ");
            }
            WriteLine();

        }
    }
}