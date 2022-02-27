# CryptoCompareAPIRESTProject

/!\ Lisez-bien ce README pour pouvoir utiliser le projet !!

1. Démarrez la solution avec Rider/VSC
2. Le projet est en version .NET Framework 4.5.2
3. Il vous faudra ensuite installer deux NuGet Packages : RestSharp 106.15.0 et Newtonsoft.Json 13.0.1
4. Normalement tout sera bon !

Chaque fonctionnalité utilise le même principe. Il y a une méthode GetData() qui requête directement l'API avec une clé et qui retourne un paquet de données de type Root.

C'est dans ce résultat de type Root que vous retrouverez toutes les données à afficher !

Pour plus de clarté dans les templates (car oui je sais dans le code c'est pas très clair mais je suis obligé de garder la même typo que l'API), n'hésitez pas à aller consulter la doc de l'API sur https://min-api.cryptocompare.com/documentation
Vous pourrez y faire des tests de requêtes qui vous montreront clairement la structure des données !
J'ai choisi 4 requêtes pour l'instant dans cette documentation :
1. Price > Multiple Symbols Full Data
2. Historical > Minute Pair OHLCV
3. Toplists > Toplist by Market Cap Full Data
4. News > Latest News Articles

Essayons d'abord d'implémenter ça, on verra ensuite si on doit rajouter plus !
