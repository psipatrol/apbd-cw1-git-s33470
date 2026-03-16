Zadanie 5.
Dlaczego tym razem merge nie był fast-forward?
Ponieważ na gałęzi gdzie powstało rozgałęzienie powstał nowy commit


• 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
Fast-forward powstanie gdy od momentu rozgałęzienia, główny branch nie dostał żadnych nowych commitów
Merge commit powstaje gdy od momentu rozgałęzianie na obu branchach pojawiły się nowe commity

• 2. Czym w praktyce różni się merge od rebase?
Merge zachowuje historię struktury gałęzi
Rebase przepisuje historię gałęzi na najaktualniejszy punkt gałęzi docelowej

• 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
Wybrałem z której gałęzi chcę zmiany, a z której je odrzucam.
Konflikt powstał przez edycję komunikatu w tej samej klasie na różnych gałęziach
