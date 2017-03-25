function chainResult = PrtFltr_MkwskSum(S, x_axis, y_axis, obj, samples, media_gausiana)
% Esta funcion es la que engloba los algoritmos de Filtro de Particulas
% y Suma de Minkowski. Como parámetros se le pasa:
% S:        el sistema de obstaculos
% x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
% y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
% obj:      objetivo intermedio 
% S: 
% S = [O1 O2 ... Ok]
% Ok.ptos: lista de puntos 

%global parameters
%media_gausiana=0.03; %media gausiana
rotar_en_x=0;
rotar_en_y=0;
rotar_en_z=1; %rotacion solo en el eje z
%samples = 25; % numero de particulas
parametros_gausiana = setGaussianParameters(media_gausiana, rotar_en_x, rotar_en_y, rotar_en_z);

%chain definition
chaint = positions2chain(x_axis, y_axis);
chainOrigin = createChain(chaint);
cadena = chain2positions(chainOrigin);

%position goal
%goal = chainEndEffectorPosition(chainDestination);
%goal = [1.2,1.2,0];
gual = [obj(1), obj(2), 0];
%destination image
%image = chain2image(chainDestination,[5,5]); 
%image1 = chain2image(chainOrigin,[1 1] ,image); 

%create particles
particles = createParticle(chainOrigin,samples,parametros_gausiana);

% pik
chainResult = pik(chainOrigin,goal,particles,S);
%goalResult = chainEndEffectorPosition(chainResult);

