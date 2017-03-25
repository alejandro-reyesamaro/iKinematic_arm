% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 17/03/2010
% function: plotUnitVector
% description:  Plot a lineal chain, from (0,0,0) to a joint quaternions
% poits
%               input: chain, joint quaternions
%               output: plot
function h=plotChain(chain,chain2)
p=chain2positions(chain);
p2=chain2positions(chain2);
%h=plot3(p(:,1),p(:,2),p(:,3));
h=plot(p(:,1),p(:,2),'-',p2(:,1),p2(:,2),'--','LineWidth',10);
grid on;

%TODO: Valid for matrix