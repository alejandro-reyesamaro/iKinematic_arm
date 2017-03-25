%Tohannic Project in Matlab
% author: Antoni Jaume i Cap√≥
% version: 2.0
% date: 26/03/2010
% function: createParticle
% description:  pik process PF
%               input: cOrigin, goal, particles, 
% S: 
% S = [O1 O2 ... Ok]
% Ok.ptos: lista de puntos 
%               output: particle
function [chainResult, it, distance] = pik(chain,goal,particles, S)%,image) %,chainDestination)
%chainResult = chain;
chainResult = particles(1);
ee = chainEndEffectorPosition(chainResult.chain);
it = 0;
I = 1;
BestParticles = [];

while(it < 50 && euclidianDistance(ee,goal) > 0.1)
% while(it<10 && not(euclidianDistance(ee,goal)<=0.1 && imageDistance(image,chainResult)<=50))
    [particles,I] = PF(goal,particles, S);%,image);
    ee = chainEndEffectorPosition(particles(I).chain);
    %chainResult = particles(I).chain;
    chainResult = particles(I);
    it = it + 1;
%     rectangle('Position',[goal(1),goal(2),3,3]);
%     hold on;
    plotChain3D(chain,'b');
    %     plotChain(chain,chainDestination);
    hold on;
    rectangle('Position',[goal(1)-0.05,goal(2)-0.05,0.3,0.1],'FaceColor','k');
    
    %OBSTACULO
%     ox = S(1).ptos(1).x; oy = S(1).ptos(1).y;
%     w = S(1).ptos(3).x - S(1).ptos(4).x;
%     h = S(1).ptos(4).y - S(1).ptos(1).y;
%     rectangle('Position',[ox,oy,w,h],'FaceColor','b');
    %-----------
    
%     plotChain3D(chainDestination,'g');
    hold on;
    plotParticles(particles,'r');
    
    for k=1:25
        if(particles(k).w ==0)
            particles(k).w
        end
    end
    
    hold on;
%     plotChain3D(particles(I).chain,'r');
    hold off;
    pause(0.1);
    
    % IrÈ guardando la mejor particula
    BestParticles = [BestParticles particles];
    
%     distance = euclidianDistance(ee,goal)
%     cost = imageDistance(image,chainResult)
end

% pause;
% hold off;
% close;
% figure;
% 
% [r, n] = size(BestParticles);
% for i=1:n
%     plotParticles(BestParticles(I,i),'r');
%     hold on;
%     rectangle('Position',[goal(1)-0.05,goal(2)-0.05,0.3,0.1],'FaceColor','k');
%     pause(0.5);
%     hold off;
% end
% 
% chainResult = particles(I).chain;
% it = it
% distance = euclidianDistance(ee,goal)
%cost = imageDistance(image,chainResult);
