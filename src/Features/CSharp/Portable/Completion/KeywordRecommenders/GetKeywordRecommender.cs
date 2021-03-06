﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Extensions.ContextQuery;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Completion.KeywordRecommenders
{
    internal class GetKeywordRecommender : AbstractSyntacticSingleKeywordRecommender
    {
        public GetKeywordRecommender()
            : base(SyntaxKind.GetKeyword)
        {
        }

        protected override bool IsValidContext(int position, CSharpSyntaxContext context, CancellationToken cancellationToken)
        {
            return
                context.TargetToken.IsAccessorDeclarationContext<PropertyDeclarationSyntax>(position, SyntaxKind.GetKeyword) ||
                context.TargetToken.IsAccessorDeclarationContext<IndexerDeclarationSyntax>(position, SyntaxKind.GetKeyword);
        }
    }
}
