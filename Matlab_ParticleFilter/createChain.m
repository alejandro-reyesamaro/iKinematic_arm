% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 26/03/2010
% function: createChain
% description:  From list point, thant represents joints positions, we
% create a chain. No include it [0 0 0], the root. WORK IN RELATIVE
%               input: p  size(p) = [number points, 3]
%               output: chain
function chain = createChain(vectores_canonicos)
chain = [];
for i = 1:size(vectores_canonicos,1)
    chain(i,1).v = vectores_canonicos(i,:);
    chain(i,1).q = quaternion(1,[0 0 0]); %unit quaternion
end