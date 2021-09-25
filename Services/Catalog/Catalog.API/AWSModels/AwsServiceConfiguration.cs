using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Catalog.API.AWSModels
{
    public class AwsServiceConfiguration
    {
        [Required]
        public AwsBucketConfiguration AwsBucketConfiguration { get; set; }
    }

    public class AwsBucketConfiguration
    {
        [Required]
        [Range(minimum: 5, maximum: 20)]
        public string BucketName { get; set; }
    }
}
