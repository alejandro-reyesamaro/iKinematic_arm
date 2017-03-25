%Tohannic Project in Matlab
% author: Antoni Jaume i Cap√≥
% version: 2.0
% date: 29/03/2010
% function: weightFunction
% description:  compute weights from euclideanDistance
%               input: particle, goal
%               output: particle
function w = weightFunction(chain,goal, S)%,image)
%euclideanDistance
ee = chainEndEffectorPosition(chain);
%Si m√©s d'un end effector, multiplicar
% w=exp((-1)*(euclidianDistance(ee,goal))*imageDistance(image,chain));
w=exp((-1)*euclidianDistance(ee,goal));

% el peso ser· cero si entra en contacto con algun obst·culo
w = w * S_Touch(chain, S);