using System.Collections.Generic;

namespace Neo4jClient.Gremlin
{
    public interface IGremlinEnumerable<TNode> : IEnumerable<NodeReference<TNode>>, IGremlinQuery
    {
    }
}