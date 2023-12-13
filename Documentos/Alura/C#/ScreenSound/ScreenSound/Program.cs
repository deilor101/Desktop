Episodio ep1 = new(1, "Episódio 1", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");


Episodio ep2 = new(2, "Episódio 2", 49);
ep2.AdicionarConvidados("Maria");
ep2.AdicionarConvidados("Marcelo");


Podcast podcast = new("Aprendendo C#", "Matheus Henrique");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();