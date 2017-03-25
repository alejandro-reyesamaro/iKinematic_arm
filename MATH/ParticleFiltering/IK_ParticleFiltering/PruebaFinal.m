clear;
clc;
close all;
%global parameters
max_iter        = 50; 
epsilon         = 0.05;
x_axis          = [0, 10, 47];
y_axis          = [0, 50, 50];
% x_axis          = [0, 0, 0.4, 1];
% y_axis          = [0, 0.6, 1, 1];
% x_axis          = [0, 0, 1];
% y_axis          = [0, 1, 1];
% obj             = [20, 40; 40, 60; 45, 65; 50, 70; 75, 70; 100, 70; 105, 65; 110, 60; 125, 40];
%obj             = [20, 40; 30, 40; 40, 38; 50, 38; 55, 32; 45, 35; 50, 35; 55, 35; 60, 35; 65, 35; 70, 35; 75, 35; 80, 35; 85, 35; 90, 35; 100, 25];
%obj = [20,40; 21.977872705736594,39.703319094139509; 23.955745411473188,39.406638188279018; 25.933618117209786,39.109957282418534; 27.91149082294638,38.813276376558044; 29.889363528682974,38.516595470697553; 31.867236234419572,38.219914564837062; 33.845108940156166,37.923233658976578; 35.82298164589276,37.626552753116087; 37.800854351629354,37.329871847255596; 39.778727057365948,37.0331909413951053; 40.0,37.0; 41.999044427529888,36.93818271470132; 43.998088855059777,36.876365429402647; 45.997133282589665,36.814548144103966; 47.996177710119554,36.752730858805286; 49.995222137649449,36.690913573506613; 50.0,36.69076582567471; 51.999253248480663,36.636117418200094; 53.998506496961326,36.581469010725485; 55.997759745441996,36.526820603250869; 57.99701299392266,36.47217219577626; 59.996266242403323,36.417523788301644; 60.0,36.417421728241614; 61.997816289243815,36.323986860916463; 63.99563257848763,36.230551993591313; 65.993448867731445,36.137117126266162; 67.99126515697526,36.0436822589410113; 69.989081446219075,35.950247391615861; 71.98689773546289,35.85681252429071; 73.984714024706719,35.763377656965559; 75.0,35.715894256760365; 76.999221931186923,35.660111913127032; 78.998443862373847,35.6043295694937; 80.99766579356077,35.548547225860368; 82.996887724747694,35.492764882227029; 84.996109655934617,35.436982538593696; 86.995331587121541,35.381200194960364; 88.994553518308464,35.325417851327032; 90.0,35.297363856784592; 91.99911633336356,35.237917362531221; 93.998232666727134,35.178470868277842; 95.997349000090693,35.11902437402447; 97.996465333454253,35.0595778797710977; 99.995581666817827,35.000131385517718741; 100.0,35.58275179021439E-10; 100.0,35.0];
obj = [25,40; 26.874850548591482,39.303626953101848; 28.749701097182964,38.607253906203695; 30.624551645774449,37.910880859305543; 32.499402194365928,37.21450781240739; 34.37425274295741,36.518134765509238; 36.249103291548899,35.821761718611086; 38.123953840140381,35.125388671712933; 39.998804388731863,34.429015624814781; 41.873654937323344,33.732642577916629; 43.748505485914826,33.0362695310184762; 45.623356034506315,32.339896484120324; 47.498206583097797,31.643523437222171; 49.373057131689279,30.947150390324019; 50.0,30.714285901064009; 51.874850511110374,30.0179127532551782; 53.749701022220741,29.321539605446347; 55.0,28.857142775033104; 56.874850554068928,28.160769742881918; 58.749701108137856,27.464396710730735; 60.0,27.0; 61.932469879202507,26.484674698879392; 63.864939758405015,25.969349397758787; 65.797409637607529,25.454024096638179; 67.72987951681003,24.938698795517574; 69.662349396012544,24.423373494396966; 71.594819275215045,23.908048193276361; 73.527289154417559,23.392722892155753; ];

media_gausiana  = 0.03; %media gausiana
samples         = 25; % numero de particulas

%obstacle definition ---------------------------------------------
% S: 
% S = [O1 O2 ... Ok]
% Ok.ptos: lista de puntos 
% p.x = 1.05; p.y = 0.6; O1.ptos(1) = p;
% p.x = 1.3; p.y = 0.6; O1.ptos(2) = p;
% p.x = 1.3; p.y = 0.9; O1.ptos(3) = p;
% p.x = 1.05; p.y = 0.9; O1.ptos(4) = p;

% p.x = 0.4; p.y = 0.6; O1.ptos(1) = p;
% p.x = 0.7; p.y = 0.6; O1.ptos(2) = p;
% p.x = 0.7; p.y = 0.9; O1.ptos(3) = p;
% p.x = 0.4; p.y = 0.9; O1.ptos(4) = p;
% 
% S = [O1 O1];

% obst_ranks = [4, 7];
% x_obst = [40, 110, 100, 50, 75, 90, 60];
% y_obst = [40, 40, 60, 60, 20, 30, 30];
obst_ranks = [4];
x_obst = [60, 90, 80, 50];
y_obst = [30, 30, 43, 43];
%-----------------------------------------------------------------
objts = max(size(obj));
plot([x_obst(1,1:4), x_obst(1)], [y_obst(1,1:4), y_obst(1)], 'b');
hold on;
rectangle('Position',[obj(objts, 1)-0.05,obj(objts,2)-0.05,0.1,0.05],'FaceColor','k');
hold on;
%plot([x_obst(1,5:7), x_obst(5)], [y_obst(1,5:7), y_obst(5)], 'b');
for i=1:size(obj)
[particle, chainResult_points, it, distance] = PrtFltr_MkwskSum(max_iter, epsilon, obst_ranks, x_obst, y_obst, x_axis, y_axis, obj(i,:), samples, media_gausiana);

hold on;
     ox = x_obst(1); oy = y_obst(1);
     w = x_obst(3) - x_obst(4);
     h = y_obst(4) - y_obst(1);
     %rectangle('Position',[ox,oy,w,h],'FaceColor','b');
hold on;
chain = positions2chain(chainResult_points(:, 1), chainResult_points(:, 2));
x_axis = chainResult_points(:, 1);
y_axis = chainResult_points(:, 2);
plotParticles(particle, 'r');
hold on;
distance
it
end